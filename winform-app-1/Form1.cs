using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app_1
{
	public partial class Form1 : Form
	{
		private List<Disco> discosList;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			DiscoNegocio disco = new DiscoNegocio();
			discosList = disco.listar();
			dgwDiscos.DataSource = discosList;
			dgwDiscos.Columns["UrlImagenTapa"].Visible = false;
			dgwDiscos.Columns["Id"].Visible = false;
			cargarImagen(discosList[0].UrlImagenTapa);
		}

		private void dgwDiscos_SelectionChanged(object sender, EventArgs e)
		{
			Disco filaSeleccionada = (Disco)dgwDiscos.CurrentRow.DataBoundItem;
			cargarImagen(filaSeleccionada.UrlImagenTapa);
		}

		private void cargarImagen(string image)
		{
			try
			{
				pbd.Load(image);
			}
			catch(Exception ex) 
			{
				pbd.Load("https://imgs.search.brave.com/YZ1SjLQxhbj0Pd5D19P6s61NQ7GMYKNHOnjLmt8DrdQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9jZG4u/c2hvcGlmeS5jb20v/cy9maWxlcy8xLzA1/MzMvMjA4OS9maWxl/cy9wbGFjZWhvbGRl/ci1pbWFnZXMtaW1h/Z2VfbGFyZ2UucG5n/P3Y9MTUzMDEyOTA4/MQ");
			}
		}
	}
}
