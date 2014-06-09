/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 02/06/2014
 * Time: 11:47 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of BuscarMaterial.
	/// </summary>
	public partial class BuscarMaterial : Form
	{
		public BuscarMaterial()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			dgvBscar.DataSource = MaterialesDal.Buscar(txtNombre.Text);
		}
		
		void BuscarMaterialLoad(object sender, EventArgs e)
		{
			dgvBscar.DataSource = MaterialesDal.Buscar(txtNombre.Text);
		}
	}
}
