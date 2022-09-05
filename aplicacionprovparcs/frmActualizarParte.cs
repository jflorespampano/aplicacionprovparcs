/*
 * Created by SharpDevelop.
 * User: Docente
 * Date: 05/09/2022
 * Time: 11:03 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace aplicacionprovparcs
{
	/// <summary>
	/// Description of frmActualizarParte.
	/// </summary>
	public partial class frmActualizarParte : Form
	{
		public frmActualizarParte()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void cargarColores(){
			//System.Collections.Generic.Dictionary 
//			this.cmbColor.Items.Insert(0,"azul");
//			this.cmbColor.Items.Insert(1,"negro");
//			this.cmbColor.Items.Insert(2,"blanco");
//			this.cmbColor.SelectedIndex=0;
			System.Data.DataTable t=new System.Data.DataTable();
			t.Columns.Add("id",Type.GetType("System.String"));
			t.Columns.Add("nombre",Type.GetType("System.String"));
			t.Rows.Add("0","azul");
			t.Rows.Add("1","verde");
			t.Rows.Add("2","blanco");
			this.cmbColor.DataSource=t;
			this.cmbColor.ValueMember="id";
			this.cmbColor.DisplayMember="nombre";
		}
		private void cargarTipos(){
			string cadCon="server=localhost;user id=root; password=; database=provpar2; pooling=false";
			//string sql="SELECT CONVERT(id, DECIMAL) AS id, descripcion FROM tipoparte";
			string sql="SELECT id, descripcion FROM tipoparte";
			System.Data.DataTable t=new System.Data.DataTable("miTabla");
			MySqlConnection con= new MySqlConnection(cadCon);
			
			con= new MySql.Data.MySqlClient.MySqlConnection(cadCon);
			try{
				MySql.Data.MySqlClient.MySqlDataAdapter da;
				da=new MySql.Data.MySqlClient.MySqlDataAdapter(sql,con);
				con.Open();
				da.Fill(t);
				con.Close();
				this.cmbTipo.DataSource=t;
				this.cmbTipo.ValueMember="id";
				this.cmbTipo.DisplayMember="descripcion";
			}catch(Exception ex){
				MessageBox.Show("error al conectar {0}", ex.Message);
			}
		
		}
		
		void FrmActualizarParteLoad(object sender, EventArgs e)
		{
			this.cargarColores();
			this.cargarTipos();
		}
		
		void BtnActualizarClick(object sender, EventArgs e)
		{
			//recuperar datos
			string id=this.txtClave.Text;
			string nombre=this.txtNombre.Text;
			var xtipo=this.cmbTipo.SelectedValue;
			string tipo=xtipo.ToString();
			string color=this.cmbColor.SelectedValue.ToString();
			string existencia=this.nudExistencia.Text;
			string sql=string.Format("update partes set nombre={0} where id={1}",nombre, id);
			MessageBox.Show(sql);
			//
			string cadCon="server=localhost;user id=root; password=; database=provpar2; pooling=false";
			MySqlConnection con= new MySqlConnection(cadCon);
			MySqlCommand comando=new MySqlCommand(sql,con);
			con.Open();
			comando.ExecuteNonQuery();
			con.Close();
		}
	}
}
