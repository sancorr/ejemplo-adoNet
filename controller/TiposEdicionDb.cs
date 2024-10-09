using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace controller
{
	public class TiposEdicionDb
	{
		public List<TiposEdicion> listarEdicion()
		{
			List<TiposEdicion> listaEdicion = new List<TiposEdicion>();
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setQuery("select Id, Descripcion from TIPOSEDICION");
				datos.readQuery();

				while (datos.Lector.Read())
				{
					TiposEdicion aux = new TiposEdicion();
					aux.Id = (int)datos.Lector["Id"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];

					listaEdicion.Add(aux);
				}

				return listaEdicion;
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
