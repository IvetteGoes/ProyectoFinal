/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 09/06/2014
 * Time: 09:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of BuscarProveedor.
	/// </summary>
	public partial class BuscarProveedor : Form
	{
		public BuscarProveedor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public ProveedorC proveedorSeleccionado {get;set;}
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
			dgv.DataSource = ProveeedoresE.Buscar(txtnombre.Text);
		}
		
		void BtncptClick(object sender, EventArgs e)
		{
			if(dgv.SelectedRows.Count == 1)
			{
				int id_prove = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
				proveedorSeleccionado = ProveeedoresE.ObtenerProveedor(id_prove);
				
				this.Close();
			}
			else
				MessageBox.Show("Debe de seleccionar una fila");
		}
		
		void BtcCancelarClick(object sender, EventArgs e)
		{
			Menu abrir = new Menu();
			abrir.Show();
			this.Hide();
		}
	}
}
