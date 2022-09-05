/*
 * Created by SharpDevelop.
 * User: Docente
 * Date: 05/09/2022
 * Time: 11:03 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace aplicacionprovparcs
{
	partial class frmActualizarParte
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
			this.lblClave = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblTipo = new System.Windows.Forms.Label();
			this.lblColor = new System.Windows.Forms.Label();
			this.lblExistencia = new System.Windows.Forms.Label();
			this.lblSminimo = new System.Windows.Forms.Label();
			this.lblSmaximo = new System.Windows.Forms.Label();
			this.lblPeso = new System.Windows.Forms.Label();
			this.lvlCC = new System.Windows.Forms.Label();
			this.lblCV = new System.Windows.Forms.Label();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.cmbColor = new System.Windows.Forms.ComboBox();
			this.nudExistencia = new System.Windows.Forms.NumericUpDown();
			this.txtStockMinimo = new System.Windows.Forms.TextBox();
			this.txtStockMaximo = new System.Windows.Forms.TextBox();
			this.txtPeso = new System.Windows.Forms.TextBox();
			this.txtCostoCompra = new System.Windows.Forms.TextBox();
			this.txtCostoVenta = new System.Windows.Forms.TextBox();
			this.btnActualizar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).BeginInit();
			this.SuspendLayout();
			// 
			// lblClave
			// 
			this.lblClave.Location = new System.Drawing.Point(13, 13);
			this.lblClave.Name = "lblClave";
			this.lblClave.Size = new System.Drawing.Size(100, 23);
			this.lblClave.TabIndex = 0;
			this.lblClave.Text = "clave";
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(13, 40);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(100, 23);
			this.lblNombre.TabIndex = 1;
			this.lblNombre.Text = "nombre";
			// 
			// lblTipo
			// 
			this.lblTipo.Location = new System.Drawing.Point(13, 67);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(100, 23);
			this.lblTipo.TabIndex = 2;
			this.lblTipo.Text = "tipo";
			// 
			// lblColor
			// 
			this.lblColor.Location = new System.Drawing.Point(13, 94);
			this.lblColor.Name = "lblColor";
			this.lblColor.Size = new System.Drawing.Size(100, 23);
			this.lblColor.TabIndex = 3;
			this.lblColor.Text = "color";
			// 
			// lblExistencia
			// 
			this.lblExistencia.Location = new System.Drawing.Point(13, 121);
			this.lblExistencia.Name = "lblExistencia";
			this.lblExistencia.Size = new System.Drawing.Size(100, 23);
			this.lblExistencia.TabIndex = 4;
			this.lblExistencia.Text = "Existencia";
			// 
			// lblSminimo
			// 
			this.lblSminimo.Location = new System.Drawing.Point(13, 148);
			this.lblSminimo.Name = "lblSminimo";
			this.lblSminimo.Size = new System.Drawing.Size(100, 23);
			this.lblSminimo.TabIndex = 5;
			this.lblSminimo.Text = "stock minimo";
			// 
			// lblSmaximo
			// 
			this.lblSmaximo.Location = new System.Drawing.Point(13, 175);
			this.lblSmaximo.Name = "lblSmaximo";
			this.lblSmaximo.Size = new System.Drawing.Size(100, 23);
			this.lblSmaximo.TabIndex = 6;
			this.lblSmaximo.Text = "Stock Máximo";
			// 
			// lblPeso
			// 
			this.lblPeso.Location = new System.Drawing.Point(13, 202);
			this.lblPeso.Name = "lblPeso";
			this.lblPeso.Size = new System.Drawing.Size(100, 23);
			this.lblPeso.TabIndex = 7;
			this.lblPeso.Text = "peso";
			// 
			// lvlCC
			// 
			this.lvlCC.Location = new System.Drawing.Point(13, 229);
			this.lvlCC.Name = "lvlCC";
			this.lvlCC.Size = new System.Drawing.Size(100, 23);
			this.lvlCC.TabIndex = 8;
			this.lvlCC.Text = "costo compra";
			// 
			// lblCV
			// 
			this.lblCV.Location = new System.Drawing.Point(13, 256);
			this.lblCV.Name = "lblCV";
			this.lblCV.Size = new System.Drawing.Size(100, 23);
			this.lblCV.TabIndex = 9;
			this.lblCV.Text = "costo venta";
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(119, 10);
			this.txtClave.Name = "txtClave";
			this.txtClave.Size = new System.Drawing.Size(100, 20);
			this.txtClave.TabIndex = 10;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(120, 37);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(121, 20);
			this.txtNombre.TabIndex = 11;
			// 
			// cmbTipo
			// 
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Location = new System.Drawing.Point(120, 64);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(121, 21);
			this.cmbTipo.TabIndex = 12;
			// 
			// cmbColor
			// 
			this.cmbColor.FormattingEnabled = true;
			this.cmbColor.Location = new System.Drawing.Point(120, 92);
			this.cmbColor.Name = "cmbColor";
			this.cmbColor.Size = new System.Drawing.Size(121, 21);
			this.cmbColor.TabIndex = 13;
			// 
			// nudExistencia
			// 
			this.nudExistencia.Location = new System.Drawing.Point(120, 120);
			this.nudExistencia.Name = "nudExistencia";
			this.nudExistencia.Size = new System.Drawing.Size(120, 20);
			this.nudExistencia.TabIndex = 14;
			// 
			// txtStockMinimo
			// 
			this.txtStockMinimo.Location = new System.Drawing.Point(119, 147);
			this.txtStockMinimo.Name = "txtStockMinimo";
			this.txtStockMinimo.Size = new System.Drawing.Size(100, 20);
			this.txtStockMinimo.TabIndex = 15;
			// 
			// txtStockMaximo
			// 
			this.txtStockMaximo.Location = new System.Drawing.Point(119, 174);
			this.txtStockMaximo.Name = "txtStockMaximo";
			this.txtStockMaximo.Size = new System.Drawing.Size(100, 20);
			this.txtStockMaximo.TabIndex = 16;
			// 
			// txtPeso
			// 
			this.txtPeso.Location = new System.Drawing.Point(120, 201);
			this.txtPeso.Name = "txtPeso";
			this.txtPeso.Size = new System.Drawing.Size(100, 20);
			this.txtPeso.TabIndex = 17;
			// 
			// txtCostoCompra
			// 
			this.txtCostoCompra.Location = new System.Drawing.Point(120, 228);
			this.txtCostoCompra.Name = "txtCostoCompra";
			this.txtCostoCompra.Size = new System.Drawing.Size(100, 20);
			this.txtCostoCompra.TabIndex = 18;
			// 
			// txtCostoVenta
			// 
			this.txtCostoVenta.Location = new System.Drawing.Point(120, 256);
			this.txtCostoVenta.Name = "txtCostoVenta";
			this.txtCostoVenta.Size = new System.Drawing.Size(100, 20);
			this.txtCostoVenta.TabIndex = 19;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(13, 321);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(84, 23);
			this.btnActualizar.TabIndex = 20;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// frmActualizarParte
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 437);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.txtCostoVenta);
			this.Controls.Add(this.txtCostoCompra);
			this.Controls.Add(this.txtPeso);
			this.Controls.Add(this.txtStockMaximo);
			this.Controls.Add(this.txtStockMinimo);
			this.Controls.Add(this.nudExistencia);
			this.Controls.Add(this.cmbColor);
			this.Controls.Add(this.cmbTipo);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtClave);
			this.Controls.Add(this.lblCV);
			this.Controls.Add(this.lvlCC);
			this.Controls.Add(this.lblPeso);
			this.Controls.Add(this.lblSmaximo);
			this.Controls.Add(this.lblSminimo);
			this.Controls.Add(this.lblExistencia);
			this.Controls.Add(this.lblColor);
			this.Controls.Add(this.lblTipo);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblClave);
			this.Name = "frmActualizarParte";
			this.Text = "frmActualizarParte";
			this.Load += new System.EventHandler(this.FrmActualizarParteLoad);
			((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.TextBox txtCostoVenta;
		private System.Windows.Forms.TextBox txtCostoCompra;
		private System.Windows.Forms.TextBox txtPeso;
		private System.Windows.Forms.TextBox txtStockMaximo;
		private System.Windows.Forms.TextBox txtStockMinimo;
		private System.Windows.Forms.NumericUpDown nudExistencia;
		private System.Windows.Forms.ComboBox cmbColor;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.Label lblCV;
		private System.Windows.Forms.Label lvlCC;
		private System.Windows.Forms.Label lblPeso;
		private System.Windows.Forms.Label lblSmaximo;
		private System.Windows.Forms.Label lblSminimo;
		private System.Windows.Forms.Label lblExistencia;
		private System.Windows.Forms.Label lblColor;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblClave;
	}
}
