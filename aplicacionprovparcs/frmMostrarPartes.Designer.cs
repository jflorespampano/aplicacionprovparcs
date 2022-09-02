/*
 * Created by SharpDevelop.
 * User: Docente
 * Date: 01/09/2022
 * Time: 08:51 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace aplicacionprovparcs
{
	partial class frmMostrarPartes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvDatosPartes = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatosPartes)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDatosPartes
			// 
			this.dgvDatosPartes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDatosPartes.Location = new System.Drawing.Point(13, 13);
			this.dgvDatosPartes.Name = "dgvDatosPartes";
			this.dgvDatosPartes.Size = new System.Drawing.Size(505, 325);
			this.dgvDatosPartes.TabIndex = 0;
			// 
			// frmMostrarPartes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 361);
			this.Controls.Add(this.dgvDatosPartes);
			this.Name = "frmMostrarPartes";
			this.Text = "frmMostrarPartes";
			this.Load += new System.EventHandler(this.FrmMostrarPartesLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvDatosPartes)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView dgvDatosPartes;
	}
}
