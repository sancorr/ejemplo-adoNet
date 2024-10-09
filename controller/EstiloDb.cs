using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace controller
{
	public class EstiloDb
	{
		public List<Estilo> listarEstilos()
		{
			List<Estilo> lista = new List<Estilo>();
			AccesoDatos datos = new AccesoDatos();
			try
			{

				datos.setQuery("select Id, Descripcion from ESTILOS");
				datos.readQuery();

				while (datos.Lector.Read())
				{
					Estilo aux = new Estilo();
					aux.Id = (int)datos.Lector["Id"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];

					lista.Add(aux);
				}

				return lista;
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
	}
}
