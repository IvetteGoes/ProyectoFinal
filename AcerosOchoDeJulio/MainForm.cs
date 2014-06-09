/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 30/05/2014
 * Time: 10:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
	
		
		
		
		void BtnIniciarSesionClick(object sender, EventArgs e)
		{
			if(txtNom.Text=="")
			{
				if(txtContra.Text=="")
				{
					Menu abrir = new Menu();
					abrir.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Contraseña incorrecta");
				}
			}
			else
			{
				MessageBox.Show("Usuario incorrecto");
			}
		}
	}
	
}

