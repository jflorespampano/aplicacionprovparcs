﻿/*
 * Created by SharpDevelop.
 * User: Docente
 * Date: 01/09/2022
 * Time: 08:41 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace aplicacionprovparcs
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.parteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tipoParteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.altaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.mostrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.parteToolStripMenuItem,
									this.tipoParteToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(428, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// parteToolStripMenuItem
			// 
			this.parteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.altaToolStripMenuItem,
									this.mostrarToolStripMenuItem});
			this.parteToolStripMenuItem.Name = "parteToolStripMenuItem";
			this.parteToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.parteToolStripMenuItem.Text = "parte";
			// 
			// altaToolStripMenuItem
			// 
			this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
			this.altaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.altaToolStripMenuItem.Text = "alta";
			// 
			// mostrarToolStripMenuItem
			// 
			this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
			this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.mostrarToolStripMenuItem.Text = "mostrar";
			this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.MostrarToolStripMenuItemClick);
			// 
			// tipoParteToolStripMenuItem
			// 
			this.tipoParteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.altaToolStripMenuItem1,
									this.mostrarToolStripMenuItem1});
			this.tipoParteToolStripMenuItem.Name = "tipoParteToolStripMenuItem";
			this.tipoParteToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.tipoParteToolStripMenuItem.Text = "tipo parte";
			// 
			// altaToolStripMenuItem1
			// 
			this.altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
			this.altaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.altaToolStripMenuItem1.Text = "alta";
			// 
			// mostrarToolStripMenuItem1
			// 
			this.mostrarToolStripMenuItem1.Name = "mostrarToolStripMenuItem1";
			this.mostrarToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.mostrarToolStripMenuItem1.Text = "mostrar";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 350);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "aplicacionprovparcs";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem tipoParteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem parteToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
