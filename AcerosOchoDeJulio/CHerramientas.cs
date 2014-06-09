/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 09/06/2014
 * Time: 10:37 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;



namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of CHerramientas.
	/// </summary>
	public partial class CHerramientas : Form
	{
		public CHerramientas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Clientesmet ClienteActual {get; set;}
		
		void Button1Click(object sender, EventArgs e)
		{
			BuscarCliente buscar = new BuscarCliente();
			buscar.ShowDialog();
			if(buscar.ClienteSeleccionado!=null)
				{
				ClienteActual= buscar.ClienteSeleccionado;
				txtnombre.Text = buscar.ClienteSeleccionado.nombre;
				txtdomicilio.Text = buscar.ClienteSeleccionado.domicilio;
				txtrfc.Text = buscar.ClienteSeleccionado.rfc;
				txttelefono.Text = buscar.ClienteSeleccionado.telefono;
			
				
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Clientesmet pclientesmet= new Clientesmet();
			pclientesmet.nombre=txtnombre.Text.Trim();
			pclientesmet.domicilio=txtdomicilio.Text.Trim(); 
			pclientesmet.rfc=txtrfc.Text.Trim();
			pclientesmet.telefono=txttelefono.Text.Trim();
			int resultado = Clientes.Agregar(pclientesmet);
			if (resultado > 0) { MessageBox.Show("Cliente Guardado Con Exito!!","Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information); 
			} 
			else { MessageBox.Show("Cliente no guardado","Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
			} 
			this.txtnombre.Clear();
			this.txtdomicilio.Clear();
			this.txttelefono.Clear();
			this.txtrfc.Clear();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Clientesmet pclientesmet = new Clientesmet();
			pclientesmet.nombre = txtnombre.Text.Trim();
			pclientesmet.domicilio = txtdomicilio.Text.Trim(); 
			pclientesmet.rfc = txtrfc.Text.Trim();
			pclientesmet.telefono = txttelefono.Text.Trim();
			pclientesmet.id = ClienteActual.id;
			
	
			if (Clientes.Editar(pclientesmet) > 0) 
			{
			MessageBox.Show("Los datos del cliente se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information); 
			}
			else { MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	
			} 
			this.txtnombre.Clear();
			this.txtdomicilio.Clear();
			this.txttelefono.Clear();
			this.txtrfc.Clear();
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Esta Seguro que desea eliminar el Cliente Actual", "Estas Seguro??", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
		{ 
			if (Clientes.Eliminar(ClienteActual.id) > 0) 
			{
				MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} 
			else 
			{ 
				MessageBox.Show("No se pudo eliminar el Cliente", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
			} 
			this.txtnombre.Clear();
			this.txtdomicilio.Clear();
			this.txttelefono.Clear();
			this.txtrfc.Clear(); 
		} 
		else MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		
		void BtncancelarClick(object sender, EventArgs e)
		{
			Menu abrir = new Menu();
			abrir.Show();
			this.Hide();
		}
	}
}
