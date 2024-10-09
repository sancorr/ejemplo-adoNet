using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_app_1
{
	class Disco
	{
		//Informacion que voy a manipular con la db
		public int Id { get; set; }
		public string Titulo { get; set; }
		public int CantidadCanciones { get; set; }
		public string UrlImagenTapa { get; set; }
		public Estilos Estilos { get; set; }
		public TiposEdicion TiposEdicion { get; set; }
	}
}
