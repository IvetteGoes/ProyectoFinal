/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 09/06/2014
 * Time: 10:44 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of BuscarCliente.
	/// </summary>
	public partial class BuscarCliente : Form
	{
		public BuscarCliente()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Clientesmet ClienteSeleccionado {get;set;}
		void BtBuscarClick(object sender, EventArgs e)
		{
			dgvBscar.DataSource = Clientes.Buscar(txtNombre.Text);
		}
		
		void BtAceptarClick(object sender, EventArgs e)
		{
			if(dgvBscar.SelectedRows.Count==1)
			{
				int id = Convert.ToInt32(dgvBscar.CurrentRow.Cells[0].Value);
				ClienteSeleccionado = Clientes.ObtenerClientes(id);
				this.Close();
			}
			else
				MessageBox.Show("Debes seleccionar una fila");
		}
		
		void BtCerrarClick(object sender, EventArgs e)
		{
			CHerramientas abrir = new CHerramientas();
			abrir.Show();
			this.Hide();
		}
	}
}
