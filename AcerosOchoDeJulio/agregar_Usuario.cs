/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 09/06/2014
 * Time: 08:31 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of agregar_Usuario.
	/// </summary>
	public partial class agregar_Usuario : Form
	{
		public agregar_Usuario()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Usuarios clienteActual {get;set;}
		public Usuarios usuarioSeleccionado {get; set;}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			Usuarios pUsuario = new Usuarios();
			pUsuario.Nombre = txtNombre.Text.Trim();
			pUsuario.Domicilio = txtDomicilio.Text.Trim();
			pUsuario.Telefono = txtTelefono.Text.Trim();
			pUsuario.CodigoPostal = txtCodigoPostal.Text.Trim();
			pUsuario.area_trabajo = txtArea.Text.Trim();
			pUsuario.Puesto = txtPuesto.Text.Trim();
			
			
			
			if ( this.txtNombre.Text.Trim()!=""&&this.txtDomicilio.Text.Trim()!=""&&this.txtTelefono.Text.Trim()!=""&&
			    this.txtCodigoPostal.Text.Trim()!=""&&this.txtArea.Text.Trim()!=""&&this.txtPuesto.Text.Trim()!=""){
				
				 int resultado = Usuarios_DAL.Agregar(pUsuario);
				MessageBox.Show("Usuario guardado con exito!!","Guardado!!",
				                MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else{
				MessageBox.Show("No se pudo Guardar el Usuario","Error!!",
				                MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			
			this.txtNombre.Clear();
			this.txtDomicilio.Clear();
			this.txtTelefono.Clear();
			this.txtCodigoPostal.Clear();
			this.txtArea.Clear();
			this.txtPuesto.Clear();
			
		}
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
			buscar_Uasuario buscar = new buscar_Uasuario();
			buscar.ShowDialog();
			
			if (buscar.usuarioSeleccionado!= null){
				
				clienteActual=buscar.usuarioSeleccionado;   //recibe al cliente seleccionado y actualiza los datos de los campos 
				txtNombre.Text = buscar.usuarioSeleccionado.Nombre;
				txtDomicilio.Text = buscar.usuarioSeleccionado.Domicilio;
				txtTelefono.Text = buscar.usuarioSeleccionado.Telefono;
				txtCodigoPostal.Text = buscar.usuarioSeleccionado.CodigoPostal;
				txtArea.Text = buscar.usuarioSeleccionado.area_trabajo;
				txtPuesto.Text = buscar.usuarioSeleccionado.Puesto;
			}
			
		}
		
		void BtnActualizarClick(object sender, EventArgs e)
		{
			Usuarios pUsuarios = new Usuarios();
			
			pUsuarios.Nombre = txtNombre.Text.Trim();
			pUsuarios.Domicilio = txtDomicilio.Text.Trim();
			pUsuarios.Telefono = txtTelefono.Text.Trim();
			pUsuarios.CodigoPostal = txtCodigoPostal.Text.Trim();
			pUsuarios.area_trabajo = txtArea.Text.Trim();
			pUsuarios.Puesto = txtPuesto.Text.Trim();
			pUsuarios.Id = clienteActual.Id;
			
			
				
			if (Usuarios_DAL.Actualizar(pUsuarios)>0){
				
				MessageBox.Show("Los datos del usuario se actualizaron","Datos Actualizados",
				                MessageBoxButtons.OK,MessageBoxIcon.Information);
				
			}else{
				MessageBox.Show("No se pudo Actualizar","ERROR al actualizar",
				                MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			
			this.txtNombre.Clear();
			this.txtDomicilio.Clear();
			this.txtTelefono.Clear();
			this.txtCodigoPostal.Clear();
			this.txtArea.Clear();
			this.txtPuesto.Clear();
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Esta seguro que desea eliminar al Usuario Seleccionado?","Usurio Elimiado",
			                    MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){
				
				if (Usuarios_DAL.Eliminar(clienteActual.Id)>0){
					
					 MessageBox.Show("Usuario Eliminado Correctamente!", "Usuario Eliminado",
					                MessageBoxButtons.OK, MessageBoxIcon.Information);
				}else{
					
					MessageBox.Show("No se pudo eliminar al Usuario","Usuario O eliminado",
					                MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					
				}
			}else
				MessageBox.Show("Se cancelo la eliminacion","Eliminacion Cancelada",
				                MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			this.txtNombre.Clear();
			this.txtDomicilio.Clear();
			this.txtTelefono.Clear();
			this.txtCodigoPostal.Clear();
			this.txtArea.Clear();
			this.txtPuesto.Clear();
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			Menu abrir = new Menu();
			abrir.Show();
			this.Hide();
		}
	}
}
