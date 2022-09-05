/*
 * Created by SharpDevelop.
 * User: Docente
 * Date: 01/09/2022
 * Time: 08:41 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace aplicacionprovparcs
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MostrarToolStripMenuItemClick(object sender, EventArgs e)
		{
			//codigo para enlazar el formulario muestra partes
			frmMostrarPartes f=new frmMostrarPartes();
			f.Text="formulario muestra partes";
			f.ShowDialog();
			
		}
		
		void ActualizarToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmActualizarParte f=new frmActualizarParte();
			f.Text="Actualizar parte";
			f.ShowDialog();
		}
	}
}
