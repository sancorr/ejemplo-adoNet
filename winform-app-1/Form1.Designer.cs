
namespace winform_app_1
{
	partial class Form1
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
			this.dgwDiscos = new System.Windows.Forms.DataGridView();
			this.pbd = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgwDiscos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbd)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwDiscos
			// 
			this.dgwDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwDiscos.Location = new System.Drawing.Point(12, 30);
			this.dgwDiscos.Name = "dgwDiscos";
			this.dgwDiscos.Size = new System.Drawing.Size(691, 150);
			this.dgwDiscos.TabIndex = 0;
			this.dgwDiscos.SelectionChanged += new System.EventHandler(this.dgwDiscos_SelectionChanged);
			// 
			// pbd
			// 
			this.pbd.Location = new System.Drawing.Point(725, 30);
			this.pbd.Name = "pbd";
			this.pbd.Size = new System.Drawing.Size(307, 150);
			this.pbd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbd.TabIndex = 1;
			this.pbd.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1044, 450);
			this.Controls.Add(this.pbd);
			this.Controls.Add(this.dgwDiscos);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwDiscos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbd)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwDiscos;
		private System.Windows.Forms.PictureBox pbd;
	}
}

