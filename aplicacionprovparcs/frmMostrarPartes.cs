/*
 * Created by SharpDevelop.
 * User: Docente
 * Date: 01/09/2022
 * Time: 08:51 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace aplicacionprovparcs
{
	/// <summary>
	/// Description of frmMostrarPartes.
	/// </summary>
	public partial class frmMostrarPartes : Form
	{
		public frmMostrarPartes()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmMostrarPartesLoad(object sender, EventArgs e)
		{
			//aqui esta el evento load
			//metemos el código para recuperar datos de la base de datos
			string cadCon="server=localhost;user id=root; password=; database=provpar2; pooling=false";
			string sql="select * from partes";
			System.Data.DataTable t=new System.Data.DataTable("miTabla");
			MySqlConnection con= new MySqlConnection(cadCon);
			
			con= new MySql.Data.MySqlClient.MySqlConnection(cadCon);
			try{
				MySql.Data.MySqlClient.MySqlDataAdapter da;
				da=new MySql.Data.MySqlClient.MySqlDataAdapter(sql,con);
				con.Open();
				da.Fill(t);
				con.Close();
				this.dgvDatosPartes.DataSource=t;
			}catch(Exception ex){
				MessageBox.Show("error al conectar {0}", ex.Message);
			}
		}
	}
}
