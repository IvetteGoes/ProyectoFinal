/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 30/05/2014
 * Time: 01:14 p. m.
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
	
	public partial class varilla_corrugada : Form
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
		public varilla_corrugada()
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
			double neto,peso,iva,precio, med,med2,med3,med4;
        	//decimal dec1;
        	neto=0.0;
			peso=0.0;
			iva=0.0;
			med=7;
			med2=12;
			med3=19;
			med4=27;
			
		//se convierte string a double usando--> Convert.ToDouble(txt.text)
			precio = Convert.ToDouble(txtPrecio.Text);
			
			
			
			if(rb38.Checked)
			{
				peso= med;
				precio=peso*precio;
				iva=precio*.16;
				neto= precio+iva;
				
				
				
			}
			else if(rb12.Checked)
			{
				peso=med2;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
			else if(rb58.Checked)
			{
				peso=med3;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
			else if(rb34.Checked)
			{
				peso=med4;
				precio=peso*precio;
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
