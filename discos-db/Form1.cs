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

namespace discos_db
{
	public partial class DiscosForm : Form
	{
		private List<Disco> listDiscos;
		public DiscosForm()
		{
			InitializeComponent();
		}

		private void DiscosForm_Load(object sender, EventArgs e)
		{
			cargar();
			cboCampo.Items.Add("Título");
			cboCampo.Items.Add("Cantidad de canciones");
			cboCampo.Items.Add("Estilo");
		}

		private void mostrarImagen(string imagen)
		{
			try
			{
				pBD.Load(imagen);
			}
			catch (Exception)
			{

				pBD.Load("https://imgs.search.brave.com/YZ1SjLQxhbj0Pd5D19P6s61NQ7GMYKNHOnjLmt8DrdQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9jZG4u/c2hvcGlmeS5jb20v/cy9maWxlcy8xLzA1/MzMvMjA4OS9maWxl/cy9wbGFjZWhvbGRl/ci1pbWFnZXMtaW1h/Z2VfbGFyZ2UucG5n/P3Y9MTUzMDEyOTA4/MQ");
			}
		}

		private void ocultarColumnas()
		{
			dGV.Columns["UrlImagenTapa"].Visible = false;
			dGV.Columns["Id"].Visible = false;
		}
		private void cargar()
		{
			DiscoDb mostrarInfo = new DiscoDb();
			try
			{
				listDiscos = mostrarInfo.listarDiscos();
				dGV.DataSource = listDiscos;
				ocultarColumnas();
				mostrarImagen(listDiscos[0].UrlImagenTapa);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString());
			}
		}

		private void dGV_SelectionChanged(object sender, EventArgs e)
		{
			Disco elementoSeleccionado = (Disco)dGV.CurrentRow.DataBoundItem;
			mostrarImagen(elementoSeleccionado.UrlImagenTapa);
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			AgregarDiscoForm alta = new AgregarDiscoForm();
			alta.ShowDialog();
			//Actualizar la carga
			cargar();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			Disco seleccionado;
			seleccionado = (Disco)dGV.CurrentRow.DataBoundItem;
			//por parametro le paso el objeto que quiero modificar al contructor de la clase
			AgregarDiscoForm modificar = new AgregarDiscoForm(seleccionado);
			modificar.ShowDialog();
			//Actualizar la carga
			cargar();
		}

		private void btnEliminarFisico_Click(object sender, EventArgs e)
		{
			DiscoDb eliminarFis = new DiscoDb();
			Disco seleccionado;
			try
			{
				DialogResult resp = MessageBox.Show("¿Seguro que desea eliminar el disco?", "ELIMINAR!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if(resp == DialogResult.Yes)
				{
					seleccionado = (Disco)dGV.CurrentRow.DataBoundItem;
					eliminarFis.eliminarFisico(seleccionado.Id);
					cargar();
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString());
			}
		}

		private void btnFiltro_Click(object sender, EventArgs e)
		{
			DiscoDb negocio = new DiscoDb();
			try
			{
				string campo = cboCampo.SelectedItem.ToString();
				string criterio = cboCriterio.SelectedItem.ToString();
				string filtro = tbxFiltroAvanzado.Text;

				dGV.DataSource = negocio.filtrar(campo, criterio, filtro);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			


		}

		private void tbxFiltro_TextChanged(object sender, EventArgs e)
		{
			List<Disco> listaFiltrada;

			if (tbxFiltro.Text != "")
			{
				listaFiltrada = listDiscos.FindAll(x => x.Titulo.ToLower().Contains(tbxFiltro.Text.ToLower()));
			}
			else
			{
				listaFiltrada = listDiscos;
			}

			dGV.DataSource = null;
			dGV.DataSource = listaFiltrada;
			ocultarColumnas();
		}

		private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
		{
			string opcion = cboCampo.SelectedItem.ToString();

			if(opcion == "Cantidad de canciones")
			{
				cboCriterio.Items.Clear();
				cboCriterio.Items.Add("Mayor a");
				cboCriterio.Items.Add("Menor a");
				cboCriterio.Items.Add("Igual a");
			}
			else
			{
				cboCriterio.Items.Clear();
				cboCriterio.Items.Add("Comienza con");
				cboCriterio.Items.Add("Termina con");
				cboCriterio.Items.Add("Contiene");
			}
		}
	}
}
