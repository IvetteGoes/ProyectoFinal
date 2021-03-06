﻿/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 30/05/2014
 * Time: 01:08 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of tuberia_diametros_mayores.
	/// </summary>
	public partial class tuberia_diametros_mayores : Form
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
					empresa=lbEmpresa.Text;
					peso=lbPeso.Text;
					metro=lbMetro.Text;
					precio=lbPrecio.Text;
					iva=lbIva.Text;
					neto=lbNeto.Text;

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
		
	
		public tuberia_diametros_mayores()
		{
			
			InitializeComponent();
			
			
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			Menu abrir = new Menu();
			abrir.Show();
			this.SetVisibleCore(false);
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double neto,peso,iva,precio, med,med2,med3,med4,med5,med6,med7,med8,med9,med10,med11,med12,med13,mtr;
        	//decimal dec1;
			neto=0.0;
			peso=0.0;
			iva=0.0;
			med=.20;
			med2=.25;
			med3=.32;
			med4=.38;
			med5=.26;
			med6=.34;
			med7=.42;
			med8=.50;
			med9=.28;
			med10=.43;
			med11=.61;
			med12=.79;
			med13=.74;
			mtr = Convert.ToDouble(txtMetro.Text); //se convierte string a double usando--> Convert.ToDouble(txt.text)
			precio = Convert.ToDouble(txtPrecio.Text);
			
			
			
			if(rb36.Checked)
			{
				peso= med*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto= precio+iva;
				
				
				
			}
			else if(rb38.Checked)
			{
				peso=med2*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
			else if(rb310.Checked)
			{
				peso=med3*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
			
			}
			else if(rb312.Checked)
			{
				peso=med4*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
			
			}
			else if(rb146.Checked)
			{
				peso=med5*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			} 
			else if(rb148.Checked)
			{
				peso=med6*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}	
 			else if(rb1410.Checked)
			{
				peso=med7*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}	
			else if(rb1412.Checked)
			{
				peso=med8*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}	
			else if(c406.Checked)
			{
				peso=med9*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
			}
			else if(c408.Checked)
			{
				peso=med10*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}	
				else if(c4010.Checked)
			{
				peso=med11*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}		
				else if(c4012.Checked)
			{
				peso=med12*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
				else if(rb3812.Checked)
			{
				peso=med13*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
				lbPeso.Text = "Peso:                       "+peso.ToString(".00");
        	    lbMetro.Text = "Metro:                       "+txtMetro.Text;
        	    lbPrecio.Text = "Precio:                      $"+precio.ToString(".00");
        	    lbIva.Text = "Iva:                            $"+iva.ToString(".00");
        	    lbNeto.Text = "Precio Neto:            $"+neto.ToString(".00");
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			imprimir_solicitud();
		}
	}
}
