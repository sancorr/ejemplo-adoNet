using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;


namespace controller
{
	public class DiscoDb
	{
		public List<Disco> listarDiscos()
		{
			List<Disco> registro = new List<Disco>();

			//1) Necesito conectarme a algun lado (objeto de tipo sqlconnection):
			SqlConnection conexion = new SqlConnection();
			//2) Necesito realizar acciones(objeto de tipo comando):
			SqlCommand comandos = new SqlCommand();
			//3) Necesito un lector de datos(objeto de tipo sqlDataReader(devuelve un objeto sqlDataReader, por eso no se crea la instancia del objeto))
			SqlDataReader lector;


			try
			{
				//1) Configurar la cadena de conexion (a donde me voy a conectar(motor de db))
				conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
				//2) Configurar el objeto comando (la secuencia sql a ejecutar)
				//2.1) especificar de que tipo va a ser el comando(en este caso de tipo texto p/ lectura de registros)
				comandos.CommandType = System.Data.CommandType.Text;
				//2.2) especificar el texto del comando (la consulta sql)
				comandos.CommandText = "select D.Titulo, D.CantidadCanciones, D.Id, D.UrlImagenTapa, E.Descripcion ESTILO, T.Descripcion FORMATO, D.IdEstilo, D.IdTipoEdicion from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id";
				//2.3) especificar en que conexion ejecutara los comandos previos
				comandos.Connection = conexion;

				//3) Abrir la conexcion
				conexion.Open();

				//4) Realizar la lectura de registros (devuelve un object data reader y lo guarda en el objeto de ese tipo.
				lector = comandos.ExecuteReader();

				//5) Leer el objeto sqlDataReader para poder acceder a la informacion
					//mientras haya algo que leer = true.
				while (lector.Read())
				{
					Disco aux = new Disco(); //Variable de tipo Disco para posicionar el puntero en las
											 //posiciones del registro

					//cargar la variable auxiliar con los datos de la variable lector que trae la informacion del registo de la base de datos
					aux.Id = (int)lector["Id"];
					aux.Titulo = (string)lector["Titulo"];
					aux.CantidadCanciones = (int)lector["CantidadCanciones"];
					if (!(lector["UrlimagenTapa"] is DBNull))
					{
						aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
					}

					aux.Estilo = new Estilo();
					aux.Estilo.Id = (int)lector["IdEstilo"];
					aux.Estilo.Descripcion = (string)lector["ESTILO"];
					aux.TipoEdicion = new TiposEdicion();
					aux.TipoEdicion.Id = (int)lector["IdTipoEdicion"];
					aux.TipoEdicion.Descripcion = (string)lector["FORMATO"];
				

					//6) agrego a la lista de objetos la informacion que esta en la variable auxiliar:
					registro.Add(aux);
				}

				//7) Cierro la conexion, desde el objeto creado para la conexion
				conexion.Close();
				//8) Todo metodo debe devolver algo, en este caso devuelvo la lista de registros cargada con la informacion de la base de datos.
				return registro;

				//En resumen: se conecta a una DB, lee una tabla de ella, transforma todo a objeto para que el compilador lo entienda y retorna una lista de objetos para que YO la entienda.
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public List<Disco> filtrar(string campo, string criterio, string filtro)
		{
			List<Disco> lista = new List<Disco>();
			AccesoDatos datos = new AccesoDatos();
			try
			{
				string consulta = "select D.Titulo, D.CantidadCanciones, D.Id, D.UrlImagenTapa, E.Descripcion ESTILO, T.Descripcion FORMATO, D.IdEstilo, D.IdTipoEdicion from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id AND ";

				if (campo == "Cantidad de canciones")
				{
					switch (criterio)
					{
						case "Mayor a":
							consulta += "D.CantidadCanciones > " + filtro;
							break;
						case "Menor a":
							consulta += "D.CantidadCanciones < " + filtro;
							break;
						default:
							consulta += "D.CantidadCanciones = " + filtro;
							break;
					}
				}
				else if (campo == "Título")
				{
					switch (criterio)
					{
						case "Comienza con":
							consulta += "D.Titulo like '" + filtro +"%' " ;
							break;
						case "Termina con":
							consulta += "D.Titulo like '%" + filtro + "'";
							break;
						default:
							consulta += "D.Titulo like '% " + filtro +"%' ";
							break;
					}
				}
				else
				{
					switch (criterio)
					{
						case "Comienza con":
							consulta += "E.Descripcion like '" + filtro + "%' ";
							break;
						case "Termina con":
							consulta += "E.Descripcion like '%" + filtro + "'";
							break;
						default:
							consulta += "E.Descripcion like '% " + filtro + "%' ";
							break;
					}
				}

				datos.setQuery(consulta);
				datos.readQuery();
				while (datos.Lector.Read())
				{
					Disco aux = new Disco();

					aux.Id = (int)datos.Lector["Id"];
					aux.Titulo = (string)datos.Lector["Titulo"];
					aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
					if (!(datos.Lector["UrlimagenTapa"] is DBNull))
					{
						aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];
					}

					aux.Estilo = new Estilo();
					aux.Estilo.Id = (int)datos.Lector["IdEstilo"];
					aux.Estilo.Descripcion = (string)datos.Lector["ESTILO"];
					aux.TipoEdicion = new TiposEdicion();
					aux.TipoEdicion.Id = (int)datos.Lector["IdTipoEdicion"];
					aux.TipoEdicion.Descripcion = (string)datos.Lector["FORMATO"];

					lista.Add(aux);
				}

				return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			};
		}

		public void agregar(Disco nuevoDisco)
		{
			AccesoDatos enviarNuevoDisco = new AccesoDatos();

			try
			{
				enviarNuevoDisco.setQuery("Insert into DISCOS (Titulo, CantidadCanciones,IdEstilo,IdTipoEdicion, UrlImagenTapa) values ('" + nuevoDisco.Titulo + "', " + nuevoDisco.CantidadCanciones + ", @idEstilo, @idTipoEdicion, @urlImagen)");
				enviarNuevoDisco.setParameters("@idEstilo", nuevoDisco.Estilo.Id);
				enviarNuevoDisco.setParameters("@idTipoEdicion", nuevoDisco.TipoEdicion.Id);
				enviarNuevoDisco.setParameters("@urlImagen", nuevoDisco.UrlImagenTapa);

				enviarNuevoDisco.ejecutarAccion();
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				enviarNuevoDisco.closeConnection();
			}



		}

		public void modificar(Disco discoModificar)
		{
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setQuery("update DISCOS set Titulo = @titulo, CantidadCanciones = @cantidad, UrlImagenTapa = @url, IdEstilo = @idEstilo, IdTipoEdicion = @idFormato where id = @id");
				datos.setParameters("@titulo", discoModificar.Titulo);
				datos.setParameters("@cantidad", discoModificar.CantidadCanciones);
				datos.setParameters("@url", discoModificar.UrlImagenTapa);
				datos.setParameters("@idEstilo", discoModificar.Estilo.Id);
				datos.setParameters("@idFormato", discoModificar.TipoEdicion.Id);
				datos.setParameters("@id", discoModificar.Id);

				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				datos.closeConnection();
			}
		}
	
	
		public void eliminarFisico(int id)
		{
			try
			{
				AccesoDatos eliminar = new AccesoDatos();
				eliminar.setQuery("delete from discos where id = @id");
				eliminar.setParameters("@id", id);
				eliminar.ejecutarAccion();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}
