using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
	public class Disco
	{
		//ANOTATIONS
		[DisplayName("Título")]
		public string Titulo { get; set; }
		public string UrlImagenTapa { get; set; }

		[DisplayName("Cantidad de canciones")]
		public int CantidadCanciones { get; set; }
		public int Id { get; set; }

		public Estilo Estilo { get; set; }
		public TiposEdicion TipoEdicion { get; set; }
	}
}
