using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controller;
using dominio;

namespace discos_db
{
	public partial class EstilosForm : Form
	{
		public EstilosForm()
		{
			InitializeComponent();
		}

		private void EstilosForm_Load(object sender, EventArgs e)
		{
			EstiloDb listaDeEstilos = new EstiloDb();
			dGVEstilos.DataSource = listaDeEstilos.listarEstilos();
		}
	}
}
