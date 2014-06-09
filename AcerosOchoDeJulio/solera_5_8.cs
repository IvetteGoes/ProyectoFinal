﻿/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 30/05/2014
 * Time: 01:01 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of solera_5_8.
	/// </summary>
	public partial class solera_5_8 : Form
	{
		private string empresa;
		private string peso;
		private string metro;
		private string precio;
		private string iva;
		private string neto;
		private Font fuente = new Font("Arial",12);
		
		public void imprimir_solicitud()
		{
					PrintDocument formulario = new PrintDocument();
					formulario.PrintPage += new PrintPageEventHandler(Datos_Presupuesto);
					PrintDialog printDialog1 = new PrintDialog();
					printDialog1.Document = formulario;
					DialogResult result = printDialog1.ShowDialog();
					if (result == DialogResult.OK)
					{
						formulario.Print();
					}
		}
					private void Datos_Presupuesto(object obj, PrintPageEventArgs ev)
				{
					float pos_x = 10;
					float pos_y = 20;
					
					//Datos= lblDatos.Text;
					
					empresa = lbempresa.Text;
					peso = lbpeso.Text;
					if (peso == null)
						return;
					metro = lbmetro.Text;
					precio = lbprecio.Text;
					iva = lbiva.Text;
					neto = lbprecioneto.Text;
					

				//Lo que vamos a imprimir
				//Estas 3 prmieras lineas de codigo son las que definen los datos del cliente
				ev.Graphics.DrawString("",fuente, Brushes.Black, pos_x, pos_y, new StringFormat());
				ev.Graphics.DrawString("",fuente, Brushes.Black, pos_x, pos_y + 50, new StringFormat());
				ev.Graphics.DrawString("",fuente, Brushes.Black, pos_x, pos_y + 70, new StringFormat());
				ev.Graphics.DrawString("",fuente, Brushes.Black, pos_x, pos_y + 90, new StringFormat());
				ev.Graphics.DrawString("",fuente, Brushes.Black, pos_x, pos_y + 110, new StringFormat());
				ev.Graphics.DrawString("",fuente, Brushes.Black, pos_x, pos_y + 130, new StringFormat());
				
					
				//Estas ultimas 3 lineas de codigo son las que capturamos en nuestro formulario
				ev.Graphics.DrawString(empresa,fuente,Brushes.Black,pos_x+65,pos_y,new StringFormat());
				ev.Graphics.DrawString(peso,fuente,Brushes.Black,pos_x+65,pos_y+50,new StringFormat());
				ev.Graphics.DrawString(metro,fuente,Brushes.Black,pos_x+65,pos_y+70,new StringFormat());
				ev.Graphics.DrawString(precio,fuente,Brushes.Black,pos_x+65,pos_y+90,new StringFormat());
				ev.Graphics.DrawString(iva,fuente,Brushes.Black,pos_x+65,pos_y+110,new StringFormat());
				ev.Graphics.DrawString(neto,fuente,Brushes.Black,pos_x+65,pos_y+130,new StringFormat());
				
					
			   
		}
		public solera_5_8()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			Menu abrir = new Menu();
			abrir.Show();
			this.SetVisibleCore(false);
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double neto,peso,iva,precio, medida,medida2,medida3,medida4,medida5,medida6,medida7,medida8, mtr;
        	//decimal dec1;
        	neto=0.0;
			peso=0.0;
			iva=0.0;
			medida=.0475;
			medida2=.0639;
			medida3=.0786;
			medida4=.095;
			medida5=.1262;
			medida6=.159;
			medida7=.1852;
			medida8=.2524;
			
			
			mtr = Convert.ToDouble(txtMetro.Text); //se convierte string a double usando--> Convert.ToDouble(txt.text)
			precio = Convert.ToDouble(txtPrecio.Text);
		    peso=Convert.ToDouble(txtPrecio.Text);
			
			
			if(rd1_1_2.Checked)
			{
				peso=medida*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
			else if(rd2.Checked)
			{
				peso=medida2*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
        	else if(rd2_1_2.Checked)
			{
				peso=medida3*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
        	else if(rd3.Checked)
			{
				peso=medida4*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
        	else if(rd4.Checked)
			{
				peso=medida5*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
        	else if(rd5.Checked)
			{
				peso=medida6*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
        	else if(rd6.Checked)
			{
				peso=medida7*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
        	else if(rd8.Checked)
			{
				peso=medida8*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
        	
        	    lbpeso.Text = "Peso:                       "+peso.ToString(".00");
        	    lbmetro.Text = "Metro:                       "+txtMetro.Text;
        	    lbprecio.Text = "Precio:                      $"+precio.ToString(".00");
        	    lbiva.Text = "Iva:                            $"+iva.ToString(".00");
        	    lbprecioneto.Text = "Precio Neto:            $"+neto.ToString(".00");
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			imprimir_solicitud();
		}
	}
}