using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using controller;
using System.IO;
using System.Configuration;

namespace discos_db
{
	public partial class AgregarDiscoForm : Form
	{

		private Disco disco = null;
		private OpenFileDialog archivo = null;
		public AgregarDiscoForm()
		{
			InitializeComponent();
		}

		//Recibo el objeto enlazado desde la otra ventana e inicializo el componente con el
		public AgregarDiscoForm(Disco disco)
		{
			InitializeComponent();
			this.disco = disco;
			Text = "Modificar disco";
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			DiscoDb claseDiscoDb = new DiscoDb();

			try
			{
				if(disco == null)
				{
					disco = new Disco();
				}

				disco.Titulo = tbxTituloDisco.Text;
				disco.CantidadCanciones = int.Parse(tbxCantidadCanciones.Text);
				disco.UrlImagenTapa = tbxUrl.Text;
				disco.Estilo = (Estilo)cbxGenero.SelectedItem;
				disco.TipoEdicion = (TiposEdicion)cbxFormato.SelectedItem;
				
				if(disco.Id != 0)
				{
					claseDiscoDb.modificar(disco);
					MessageBox.Show("Modificado con exito");
				}
				else
				{
					claseDiscoDb.agregar(disco);
					MessageBox.Show("Agregado con exito");
				}
				
				if(archivo != null && !(tbxUrl.Text.ToLower().Contains("http")))
				{
					//Guardo imagen si se levanta localmente con el OpenFileDialog, por archivo de configuracion
					File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
				}


				this.Close();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString());
			}
		}

		private void AgregarDiscoForm_Load(object sender, EventArgs e)
		{
			EstiloDb elementoEstilo = new EstiloDb();
			TiposEdicionDb elementoEdicion = new TiposEdicionDb();

			try
			{
				cbxGenero.DataSource = elementoEstilo.listarEstilos();
				cbxGenero.ValueMember = "Id";
				cbxGenero.DisplayMember = "Descripcion";
				cbxFormato.DataSource = elementoEdicion.listarEdicion();
				cbxFormato.ValueMember = "Id";
				cbxFormato.DisplayMember = "Descripcion";

				//validacion para precargar campos en caso de que sea una modificacion
				if (disco != null)
				{
					tbxTituloDisco.Text = disco.Titulo;
					tbxCantidadCanciones.Text = disco.CantidadCanciones.ToString();
					tbxUrl.Text = disco.UrlImagenTapa;
					//pre cargar imagen en modificar
					mostrarImagen(disco.UrlImagenTapa);
					cbxGenero.SelectedValue = disco.Estilo.Id;
					cbxFormato.SelectedValue = disco.TipoEdicion.Id;
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString());
			}
		}

		private void tbxUrl_Leave(object sender, EventArgs e)
		{
			mostrarImagen(tbxUrl.Text);
		}

		private void mostrarImagen(string imagen)
		{
			try
			{
				pbxUrl.Load(imagen);
			}
			catch (Exception)
			{

				pbxUrl.Load("https://imgs.search.brave.com/YZ1SjLQxhbj0Pd5D19P6s61NQ7GMYKNHOnjLmt8DrdQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9jZG4u/c2hvcGlmeS5jb20v/cy9maWxlcy8xLzA1/MzMvMjA4OS9maWxl/cy9wbGFjZWhvbGRl/ci1pbWFnZXMtaW1h/Z2VfbGFyZ2UucG5n/P3Y9MTUzMDEyOTA4/MQ");
			}
		}

		private void btnAgregarImagen_Click(object sender, EventArgs e)
		{
			archivo = new OpenFileDialog();
			archivo.Filter = "jpg|*.jpg;|png|*.png";

			if(archivo.ShowDialog() == DialogResult.OK)
			{
				tbxUrl.Text = archivo.FileName;
				mostrarImagen(archivo.FileName);
			}
		}
	}
}
