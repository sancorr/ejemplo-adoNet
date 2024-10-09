
namespace discos_db
{
	partial class TipoEdicionForm
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
			this.dGVTipoEdicion = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dGVTipoEdicion)).BeginInit();
			this.SuspendLayout();
			// 
			// dGVTipoEdicion
			// 
			this.dGVTipoEdicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGVTipoEdicion.Location = new System.Drawing.Point(252, 95);
			this.dGVTipoEdicion.Name = "dGVTipoEdicion";
			this.dGVTipoEdicion.Size = new System.Drawing.Size(292, 240);
			this.dGVTipoEdicion.TabIndex = 0;
			// 
			// TipoEdicionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dGVTipoEdicion);
			this.Name = "TipoEdicionForm";
			this.Text = "TipoEdicionForm";
			this.Load += new System.EventHandler(this.TipoEdicionForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dGVTipoEdicion)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dGVTipoEdicion;
	}
}