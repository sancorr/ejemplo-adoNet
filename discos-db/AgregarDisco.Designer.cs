
namespace discos_db
{
	partial class AgregarDiscoForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelTituloDisco = new System.Windows.Forms.Label();
			this.labelCantidadCaciones = new System.Windows.Forms.Label();
			this.tbxTituloDisco = new System.Windows.Forms.TextBox();
			this.tbxCantidadCanciones = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.cbxGenero = new System.Windows.Forms.ComboBox();
			this.cbxFormato = new System.Windows.Forms.ComboBox();
			this.lblGenero = new System.Windows.Forms.Label();
			this.lblFormato = new System.Windows.Forms.Label();
			this.lblUrl = new System.Windows.Forms.Label();
			this.tbxUrl = new System.Windows.Forms.TextBox();
			this.pbxUrl = new System.Windows.Forms.PictureBox();
			this.btnAgregarImagen = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbxUrl)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTituloDisco
			// 
			this.labelTituloDisco.AutoSize = true;
			this.labelTituloDisco.Location = new System.Drawing.Point(46, 59);
			this.labelTituloDisco.Name = "labelTituloDisco";
			this.labelTituloDisco.Size = new System.Drawing.Size(61, 13);
			this.labelTituloDisco.TabIndex = 0;
			this.labelTituloDisco.Text = "Titulo disco";
			// 
			// labelCantidadCaciones
			// 
			this.labelCantidadCaciones.AutoSize = true;
			this.labelCantidadCaciones.Location = new System.Drawing.Point(46, 103);
			this.labelCantidadCaciones.Name = "labelCantidadCaciones";
			this.labelCantidadCaciones.Size = new System.Drawing.Size(116, 13);
			this.labelCantidadCaciones.TabIndex = 1;
			this.labelCantidadCaciones.Text = "Cantidad de canciones";
			// 
			// tbxTituloDisco
			// 
			this.tbxTituloDisco.Location = new System.Drawing.Point(168, 52);
			this.tbxTituloDisco.Name = "tbxTituloDisco";
			this.tbxTituloDisco.Size = new System.Drawing.Size(150, 20);
			this.tbxTituloDisco.TabIndex = 0;
			// 
			// tbxCantidadCanciones
			// 
			this.tbxCantidadCanciones.Location = new System.Drawing.Point(168, 96);
			this.tbxCantidadCanciones.Name = "tbxCantidadCanciones";
			this.tbxCantidadCanciones.Size = new System.Drawing.Size(150, 20);
			this.tbxCantidadCanciones.TabIndex = 1;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(49, 309);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 5;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(242, 309);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 6;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// cbxGenero
			// 
			this.cbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxGenero.FormattingEnabled = true;
			this.cbxGenero.Location = new System.Drawing.Point(168, 175);
			this.cbxGenero.Name = "cbxGenero";
			this.cbxGenero.Size = new System.Drawing.Size(149, 21);
			this.cbxGenero.TabIndex = 3;
			// 
			// cbxFormato
			// 
			this.cbxFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxFormato.FormattingEnabled = true;
			this.cbxFormato.Location = new System.Drawing.Point(168, 214);
			this.cbxFormato.Name = "cbxFormato";
			this.cbxFormato.Size = new System.Drawing.Size(149, 21);
			this.cbxFormato.TabIndex = 4;
			// 
			// lblGenero
			// 
			this.lblGenero.AutoSize = true;
			this.lblGenero.Location = new System.Drawing.Point(46, 183);
			this.lblGenero.Name = "lblGenero";
			this.lblGenero.Size = new System.Drawing.Size(42, 13);
			this.lblGenero.TabIndex = 8;
			this.lblGenero.Text = "Genero";
			// 
			// lblFormato
			// 
			this.lblFormato.AutoSize = true;
			this.lblFormato.Location = new System.Drawing.Point(46, 222);
			this.lblFormato.Name = "lblFormato";
			this.lblFormato.Size = new System.Drawing.Size(45, 13);
			this.lblFormato.TabIndex = 9;
			this.lblFormato.Text = "Formato";
			// 
			// lblUrl
			// 
			this.lblUrl.AutoSize = true;
			this.lblUrl.Location = new System.Drawing.Point(46, 142);
			this.lblUrl.Name = "lblUrl";
			this.lblUrl.Size = new System.Drawing.Size(66, 13);
			this.lblUrl.TabIndex = 10;
			this.lblUrl.Text = "URL imagen";
			// 
			// tbxUrl
			// 
			this.tbxUrl.Location = new System.Drawing.Point(168, 135);
			this.tbxUrl.Name = "tbxUrl";
			this.tbxUrl.Size = new System.Drawing.Size(150, 20);
			this.tbxUrl.TabIndex = 2;
			this.tbxUrl.Leave += new System.EventHandler(this.tbxUrl_Leave);
			// 
			// pbxUrl
			// 
			this.pbxUrl.Location = new System.Drawing.Point(397, 52);
			this.pbxUrl.Name = "pbxUrl";
			this.pbxUrl.Size = new System.Drawing.Size(209, 183);
			this.pbxUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxUrl.TabIndex = 12;
			this.pbxUrl.TabStop = false;
			// 
			// btnAgregarImagen
			// 
			this.btnAgregarImagen.Location = new System.Drawing.Point(343, 135);
			this.btnAgregarImagen.Name = "btnAgregarImagen";
			this.btnAgregarImagen.Size = new System.Drawing.Size(35, 23);
			this.btnAgregarImagen.TabIndex = 13;
			this.btnAgregarImagen.Text = "+";
			this.btnAgregarImagen.UseVisualStyleBackColor = true;
			this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
			// 
			// AgregarDiscoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(662, 404);
			this.Controls.Add(this.btnAgregarImagen);
			this.Controls.Add(this.pbxUrl);
			this.Controls.Add(this.tbxUrl);
			this.Controls.Add(this.lblUrl);
			this.Controls.Add(this.lblFormato);
			this.Controls.Add(this.lblGenero);
			this.Controls.Add(this.cbxFormato);
			this.Controls.Add(this.cbxGenero);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.tbxCantidadCanciones);
			this.Controls.Add(this.tbxTituloDisco);
			this.Controls.Add(this.labelCantidadCaciones);
			this.Controls.Add(this.labelTituloDisco);
			this.Name = "AgregarDiscoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar Disco";
			this.Load += new System.EventHandler(this.AgregarDiscoForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbxUrl)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTituloDisco;
		private System.Windows.Forms.Label labelCantidadCaciones;
		private System.Windows.Forms.TextBox tbxTituloDisco;
		private System.Windows.Forms.TextBox tbxCantidadCanciones;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.ComboBox cbxGenero;
		private System.Windows.Forms.ComboBox cbxFormato;
		private System.Windows.Forms.Label lblGenero;
		private System.Windows.Forms.Label lblFormato;
		private System.Windows.Forms.Label lblUrl;
		private System.Windows.Forms.TextBox tbxUrl;
		private System.Windows.Forms.PictureBox pbxUrl;
		private System.Windows.Forms.Button btnAgregarImagen;
	}
}