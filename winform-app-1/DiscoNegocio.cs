using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace winform_app_1
{
	class DiscoNegocio
	{
		public List<Disco> listar()
		{
			List<Disco> lista = new List<Disco>();

			//variable/objeto de tipo sqlconnection para conectarme
			SqlConnection conexion = new SqlConnection();

			//variable/objeto de tipo sqlcommand para realizar acciones en la conexion
			SqlCommand comandos = new SqlCommand();

			//variable/objeto de tipo sqldatareader para leer la informacion
			SqlDataReader lector;

			try
			{
				conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
				comandos.CommandType = System.Data.CommandType.Text;
				comandos.CommandText = "select D.Id, D.Titulo, D.UrlImagenTapa, D.CantidadCanciones, E.Descripcion Estilo, T.Descripcion Formato from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id";
				comandos.Connection = conexion;

				conexion.Open();
				lector = comandos.ExecuteReader();
				//Transformar el objeto sqlDataReader en lector a una lista de objetos

				while (lector.Read())
				{
					Disco aux = new Disco();

					aux.Id = (int)lector["Id"];
					aux.Titulo = (string)lector["Titulo"];
					aux.CantidadCanciones = (int)lector["CantidadCanciones"];
					aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
					aux.Estilos = new Estilos();
					aux.Estilos.Descripcion = (string)lector["Estilo"];
					aux.TiposEdicion = new TiposEdicion();
					aux.TiposEdicion.Descripcion = (string)lector["Formato"];

					lista.Add(aux);
				}

				conexion.Close();
				return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}

		}
	}
}
