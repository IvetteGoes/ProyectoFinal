/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 09/06/2014
 * Time: 09:33 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of proveedor.
	/// </summary>
	public partial class proveedor : Form
	{
		public proveedor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public ProveedorC proveedorActual {get;set;}
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
			BuscarProveedor buscar = new BuscarProveedor();
			buscar.ShowDialog();
			
			if (buscar.proveedorSeleccionado!=null)
			{
			    proveedorActual = buscar.proveedorSeleccionado;
				
				txtnombre.Text=buscar.proveedorSeleccionado.nombre_prove;
				txtdireccion.Text=buscar.proveedorSeleccionado.direccion;
				txtcolonia.Text=buscar.proveedorSeleccionado.colonia;
				txtciudad.Text=buscar.proveedorSeleccionado.ciudad;
				txtrfc.Text=buscar.proveedorSeleccionado.rfc;
				txtcodp.Text=buscar.proveedorSeleccionado.codigo_postal;
				txttel.Text=buscar.proveedorSeleccionado.telefono;
				txtcorreo.Text=buscar.proveedorSeleccionado.correo_electronico;
			}
		}
		
		void BtnActualizarClick(object sender, EventArgs e)
		{
			ProveedorC pProveedor = new ProveedorC();
			pProveedor.nombre_prove = txtnombre.Text.Trim();
			pProveedor.direccion = txtdireccion.Text.Trim();
			pProveedor.colonia = txtcolonia.Text.Trim();
			pProveedor.ciudad = txtciudad.Text.Trim();
			pProveedor.rfc = txtrfc.Text.Trim();
			pProveedor.codigo_postal =txtcodp.Text.Trim();
			pProveedor.telefono = txttel.Text.Trim();
			pProveedor.correo_electronico = txtcorreo.Text.Trim();
			pProveedor.id = proveedorActual.id;
			
			if(ProveeedoresE.Editar(pProveedor) > 0)
			{
				MessageBox.Show("Los datos del proveedor se actualizaron", "Datos Actualizados", MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("NO se puede actualizar", "Error al Actualizar", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			ProveedorC pProveedor = new ProveedorC();
			pProveedor.nombre_prove = txtnombre.Text.Trim();
			pProveedor.direccion = txtdireccion.Text.Trim();
			pProveedor.colonia = txtcolonia.Text.Trim();
			pProveedor.ciudad = txtciudad.Text.Trim();
			pProveedor.rfc = txtrfc.Text.Trim();
			pProveedor.codigo_postal = txtcodp.Text.Trim();
			pProveedor.telefono = txttel.Text.Trim();
			pProveedor.correo_electronico = txtcodp.Text.Trim();
			
			int resultado = ProveeedoresE.Agregar(pProveedor);
			if(resultado > 0)
			{
				MessageBox.Show("Proveedor Guardado con Exito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("No se pudo guardar el Proveedor", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("Estas seguro de eliminar el proveedor?", "Estas seguro?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
			   {
			   	if (ProveeedoresE.Eliminar(proveedorActual.id) > 0)
			   	{
			   		MessageBox.Show("Proveedor Eliminado exitosamente", "Proveedor eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			   	}
			   	else
			   	{
			   		MessageBox.Show("No se puede eliminar el proveedor", "Proveedor no Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			   		
			   	}
			   	
			   }
			   else
			   	
			   	MessageBox.Show("Se cancelo la eliminacion", "eliminacion cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			Menu abrir = new Menu();
			abrir.Show();
			this.SetVisibleCore(false);
		}
	}
}
