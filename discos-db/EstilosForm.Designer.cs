
namespace discos_db
{
	partial class EstilosForm
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
			this.dGVEstilos = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dGVEstilos)).BeginInit();
			this.SuspendLayout();
			// 
			// dGVEstilos
			// 
			this.dGVEstilos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGVEstilos.Location = new System.Drawing.Point(244, 127);
			this.dGVEstilos.Name = "dGVEstilos";
			this.dGVEstilos.Size = new System.Drawing.Size(348, 174);
			this.dGVEstilos.TabIndex = 0;
			// 
			// EstilosForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dGVEstilos);
			this.Name = "EstilosForm";
			this.Text = "EstilosForm";
			this.Load += new System.EventHandler(this.EstilosForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dGVEstilos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dGVEstilos;
	}
}