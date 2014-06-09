/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 09/06/2014
 * Time: 08:50 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of buscar_Uasuario.
	/// </summary>
	public partial class buscar_Uasuario : Form
	{
		public buscar_Uasuario()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
			dataGrid_Usurios.DataSource = Usuarios_DAL.Buscar(txtNombre.Text);
		}
		public Usuarios usuarioSeleccionado {get; set;}
		void BtnAceptarClick(object sender, EventArgs e)
		{
			string id = Convert.ToString(dataGrid_Usurios.CurrentRow.Cells[0].Value);
				                             usuarioSeleccionado = Usuarios_DAL.obtener_Cliente(id);
				                             
				                             this.Close();
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
