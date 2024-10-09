
namespace discos_db
{
	partial class DiscosForm
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.dGV = new System.Windows.Forms.DataGridView();
			this.pBD = new System.Windows.Forms.PictureBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminarFisico = new System.Windows.Forms.Button();
			this.filtroLabel = new System.Windows.Forms.Label();
			this.tbxFiltro = new System.Windows.Forms.TextBox();
			this.btnFiltro = new System.Windows.Forms.Button();
			this.lblCampo = new System.Windows.Forms.Label();
			this.lblCriterio = new System.Windows.Forms.Label();
			this.cboCampo = new System.Windows.Forms.ComboBox();
			this.cboCriterio = new System.Windows.Forms.ComboBox();
			this.lblFiltroAvanzado = new System.Windows.Forms.Label();
			this.tbxFiltroAvanzado = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBD)).BeginInit();
			this.SuspendLayout();
			// 
			// dGV
			// 
			this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dGV.Location = new System.Drawing.Point(55, 50);
			this.dGV.MultiSelect = false;
			this.dGV.Name = "dGV";
			this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV.Size = new System.Drawing.Size(599, 150);
			this.dGV.TabIndex = 0;
			this.dGV.SelectionChanged += new System.EventHandler(this.dGV_SelectionChanged);
			// 
			// pBD
			// 
			this.pBD.Location = new System.Drawing.Point(661, 50);
			this.pBD.Name = "pBD";
			this.pBD.Size = new System.Drawing.Size(204, 150);
			this.pBD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pBD.TabIndex = 1;
			this.pBD.TabStop = false;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(55, 251);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 2;
			this.btnAgregar.Text = "Agregar disco";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(165, 251);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 23);
			this.btnModificar.TabIndex = 3;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnEliminarFisico
			// 
			this.btnEliminarFisico.Location = new System.Drawing.Point(284, 251);
			this.btnEliminarFisico.Name = "btnEliminarFisico";
			this.btnEliminarFisico.Size = new System.Drawing.Size(75, 23);
			this.btnEliminarFisico.TabIndex = 4;
			this.btnEliminarFisico.Text = "Eliminar fisico";
			this.btnEliminarFisico.UseVisualStyleBackColor = true;
			this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
			// 
			// filtroLabel
			// 
			this.filtroLabel.AutoSize = true;
			this.filtroLabel.Location = new System.Drawing.Point(61, 23);
			this.filtroLabel.Name = "filtroLabel";
			this.filtroLabel.Size = new System.Drawing.Size(34, 13);
			this.filtroLabel.TabIndex = 5;
			this.filtroLabel.Text = "Filtrito";
			// 
			// tbxFiltro
			// 
			this.tbxFiltro.Location = new System.Drawing.Point(121, 15);
			this.tbxFiltro.Name = "tbxFiltro";
			this.tbxFiltro.Size = new System.Drawing.Size(133, 20);
			this.tbxFiltro.TabIndex = 6;
			this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged);
			// 
			// btnFiltro
			// 
			this.btnFiltro.Location = new System.Drawing.Point(577, 299);
			this.btnFiltro.Name = "btnFiltro";
			this.btnFiltro.Size = new System.Drawing.Size(75, 23);
			this.btnFiltro.TabIndex = 7;
			this.btnFiltro.Text = "Buscar";
			this.btnFiltro.UseVisualStyleBackColor = true;
			this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
			// 
			// lblCampo
			// 
			this.lblCampo.AutoSize = true;
			this.lblCampo.Location = new System.Drawing.Point(52, 309);
			this.lblCampo.Name = "lblCampo";
			this.lblCampo.Size = new System.Drawing.Size(40, 13);
			this.lblCampo.TabIndex = 8;
			this.lblCampo.Text = "Campo";
			// 
			// lblCriterio
			// 
			this.lblCriterio.AutoSize = true;
			this.lblCriterio.Location = new System.Drawing.Point(234, 309);
			this.lblCriterio.Name = "lblCriterio";
			this.lblCriterio.Size = new System.Drawing.Size(39, 13);
			this.lblCriterio.TabIndex = 9;
			this.lblCriterio.Text = "Criterio";
			// 
			// cboCampo
			// 
			this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCampo.FormattingEnabled = true;
			this.cboCampo.Location = new System.Drawing.Point(100, 301);
			this.cboCampo.Name = "cboCampo";
			this.cboCampo.Size = new System.Drawing.Size(121, 21);
			this.cboCampo.TabIndex = 10;
			this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
			// 
			// cboCriterio
			// 
			this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCriterio.FormattingEnabled = true;
			this.cboCriterio.Location = new System.Drawing.Point(282, 301);
			this.cboCriterio.Name = "cboCriterio";
			this.cboCriterio.Size = new System.Drawing.Size(121, 21);
			this.cboCriterio.TabIndex = 11;
			// 
			// lblFiltroAvanzado
			// 
			this.lblFiltroAvanzado.AutoSize = true;
			this.lblFiltroAvanzado.Location = new System.Drawing.Point(416, 309);
			this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
			this.lblFiltroAvanzado.Size = new System.Drawing.Size(29, 13);
			this.lblFiltroAvanzado.TabIndex = 12;
			this.lblFiltroAvanzado.Text = "Filtro";
			// 
			// tbxFiltroAvanzado
			// 
			this.tbxFiltroAvanzado.Location = new System.Drawing.Point(464, 302);
			this.tbxFiltroAvanzado.Name = "tbxFiltroAvanzado";
			this.tbxFiltroAvanzado.Size = new System.Drawing.Size(100, 20);
			this.tbxFiltroAvanzado.TabIndex = 13;
			// 
			// DiscosForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1045, 450);
			this.Controls.Add(this.tbxFiltroAvanzado);
			this.Controls.Add(this.lblFiltroAvanzado);
			this.Controls.Add(this.cboCriterio);
			this.Controls.Add(this.cboCampo);
			this.Controls.Add(this.lblCriterio);
			this.Controls.Add(this.lblCampo);
			this.Controls.Add(this.btnFiltro);
			this.Controls.Add(this.tbxFiltro);
			this.Controls.Add(this.filtroLabel);
			this.Controls.Add(this.btnEliminarFisico);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.pBD);
			this.Controls.Add(this.dGV);
			this.Name = "DiscosForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Informacion de discos";
			this.Load += new System.EventHandler(this.DiscosForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dGV;
		private System.Windows.Forms.PictureBox pBD;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminarFisico;
		private System.Windows.Forms.Label filtroLabel;
		private System.Windows.Forms.TextBox tbxFiltro;
		private System.Windows.Forms.Button btnFiltro;
		private System.Windows.Forms.Label lblCampo;
		private System.Windows.Forms.Label lblCriterio;
		private System.Windows.Forms.ComboBox cboCampo;
		private System.Windows.Forms.ComboBox cboCriterio;
		private System.Windows.Forms.Label lblFiltroAvanzado;
		private System.Windows.Forms.TextBox tbxFiltroAvanzado;
	}
}

