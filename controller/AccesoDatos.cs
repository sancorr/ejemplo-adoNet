using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace controller
{
	public class AccesoDatos
	{
		private SqlConnection conexion;
		private SqlCommand comandos;
		private SqlDataReader lector;

		//prop para poder leer el objeto lector (que es privado)
		public SqlDataReader Lector { 
			get { return lector; } 
		}

		//CONSTRUCTOR
		public AccesoDatos() {
			conexion = new SqlConnection("server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true");
			comandos = new SqlCommand();
		}

		//Metodo publico para hacer la consulta
		public void setQuery(string query)
		{
			comandos.CommandType = System.Data.CommandType.Text;
			comandos.CommandText = query;
		}

		//Metodo para ejecutar la lecutra
		public void readQuery()
		{
			comandos.Connection = conexion;
			try
			{
				conexion.Open();
				lector = comandos.ExecuteReader();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void ejecutarAccion()
		{
			comandos.Connection = conexion;
			try
			{
				conexion.Open();
				comandos.ExecuteNonQuery();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public void setParameters(string nombre, object valor)
		{
			comandos.Parameters.AddWithValue(nombre, valor);
		}

		public void closeConnection()
		{
			if (lector != null)
			
				lector.Close();
			
			conexion.Close();
		}


	}
}
