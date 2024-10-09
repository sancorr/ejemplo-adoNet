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

namespace discos_db
{
	public partial class TipoEdicionForm : Form
	{
		public TipoEdicionForm()
		{
			InitializeComponent();
		}

		private void TipoEdicionForm_Load(object sender, EventArgs e)
		{
			TiposEdicionDb listaEdiciones = new TiposEdicionDb();
			dGVTipoEdicion.DataSource = listaEdiciones.listarEdicion();
		}
	}
}
