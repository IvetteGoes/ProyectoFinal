/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 03/06/2014
 * Time: 01:10 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of Herramientas.
	/// </summary>
	public partial class Herramientas : Form
	{
		public Herramientas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Material MaterialAcual {get;set;}
		void Button2Click(object sender, EventArgs e)
		{
			Menu abrir = new Menu();
			abrir.Show();
			this.SetVisibleCore(false);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Material pMaterial = new Material();
            pMaterial.Nombre = txtNombre.Text.Trim();
            pMaterial.Medida= txtMedida.Text.Trim();
            pMaterial.Peso= txtPeso.Text.Trim();
            
            int resultado = MaterialesDal.Agregar(pMaterial);
            if (resultado > 0)
            {
                MessageBox.Show("Material Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el material", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            this.txtNombre.Clear();
            this.txtMedida.Clear();
            this.txtPeso.Clear();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			BuscarMaterial buscar = new BuscarMaterial();
			buscar.ShowDialog();
			
			
			if(buscar.MaterialSeleccionado!=null)
			{
				MaterialAcual=buscar.MaterialSeleccionado;
				txtNombre.Text = buscar.MaterialSeleccionado.Nombre;
				txtMedida.Text = buscar.MaterialSeleccionado.Medida;
				txtPeso.Text = buscar.MaterialSeleccionado.Peso;
			}
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Material pMaterial = new Material();
			pMaterial.Nombre=txtNombre.Text.Trim();
			pMaterial.Medida=txtMedida.Text.Trim();
			pMaterial.Peso=txtPeso.Text.Trim();
			pMaterial.Id= MaterialAcual.Id;
            

            if (MaterialesDal.Editar(pMaterial) > 0)
            {
                MessageBox.Show("Los datos del cliente se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            this.txtNombre.Clear();
            this.txtMedida.Clear();
            this.txtPeso.Clear();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Esta Seguro que desea eliminar el Material Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MaterialesDal.Eliminar(MaterialAcual.Id) > 0)
                {
                    MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Cliente", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
                this.txtPeso.Clear();
                this.txtNombre.Clear();
                this.txtMedida.Clear();
                
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	
	}
}
