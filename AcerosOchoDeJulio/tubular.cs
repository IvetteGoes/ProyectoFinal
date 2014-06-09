/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 30/05/2014
 * Time: 01:09 p. m.
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
	/// Description of tubular.
	/// </summary>
	public partial class tubular : Form
	{
		private string empresa;
		private string peso;
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
				ev.Graphics.DrawString(precio,fuente,Brushes.Black,pos_x+65,pos_y+90,new StringFormat());
				ev.Graphics.DrawString(iva,fuente,Brushes.Black,pos_x+65,pos_y+110,new StringFormat());
				ev.Graphics.DrawString(neto,fuente,Brushes.Black,pos_x+65,pos_y+130,new StringFormat());
					}
		public tubular()
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
			double neto,peso,iva,precio, med,med2,med3,med4,med5,med6,med7,med8,med9,med10,med11,med12,med13,med14,med15,med16;
        	//decimal dec1;
        	neto=0.0;
			peso=0.0;
			iva=0.0;
			med=3;
			med2=4;
			med3=6;
			med4=7;
			med5=9;
			med6=12;
			med7=4;
			med8=6;
			med9=6;
			med10=7;
			med11=9;
			med12=9;
			med13=11;
			med14=12;
			med15=13;
			med16=16;
			precio = Convert.ToDouble(txtPrecio.Text);
			
			
			
			if(rb12.Checked)
			{
				peso=med;
				precio=med*precio;
				iva=precio*.16;
				neto= precio+iva;
				
				
				
			}
			else if(rb34.Checked)
			{
				peso=med2;
				precio=med2*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
			else if(rb1.Checked)
			{
				peso=med3;
				precio=med3*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
			else if(rb114.Checked)
			{
				peso=med4;
				precio=med4*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
			else if(rb112.Checked)
			{
				peso=med5;
				precio=med5*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
			else if(rb2.Checked)
			{
				peso=med6;
				precio=med6*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}	
 			else if(rb1x12.Checked)
			{
 				peso=med7;
				precio=med7*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}	
			else if(rb114x34.Checked)
			{
				peso=med8;
				precio=med8*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}	
			else if(rb112x12.Checked)
			{
				peso=med9;
				precio=med9*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
			else if(rb134x34.Checked)
			{
				peso=med10;
				precio=med10*precio;
				iva=precio*.16;
				neto=precio+iva;
			
			}	
				else if(rb2x1.Checked)
			{
				peso=med11;	
				precio=med11*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}		
				else if(rb214x34.Checked)
			{
				peso=med12;
				precio=med12*precio;
				iva=precio*.16;
				neto=precio+iva;
			
			}
				else if(rb212x114.Checked)
			{
				peso=med13;
				precio=med13*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
				else if(rb212x112.Checked)
			{
				peso=med14;
				precio=med14*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
				else if(rb3x112.Checked)
			{
				peso=med15;
				precio=med15*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}	
				else if(rb4x112.Checked)
			{
				peso=med16;
				precio=med16*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}	
				lbPeso.Text = "Peso:                       "+peso.ToString(".00");
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
