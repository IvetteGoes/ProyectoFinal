/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 30/05/2014
 * Time: 12:30 p. m.
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
	/// Description of blanco.
	/// </summary>
	public partial class blanco : Form
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
					
					empresa = label11.Text;
					peso = label3.Text;
					metro = label5.Text;
					precio = label6.Text;
					iva = label7.Text;
					neto = label8.Text;
					

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
		public blanco()
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
		
		void BlancoLoad(object sender, EventArgs e)
		{
			
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double neto, peso, precio, iva, medida,medida1,medida2,medida3,medida4,medida5,medida6,medida7, mtr;
			neto=0.0;
			peso=0.0;
			iva=0.0;
			
			medida=.0295;
			medida1=.0409;
			medida2=.0573;
			medida3=.0704;
			medida4=.0819;
			medida5=.0573;
			medida6=.0704;
			medida7=.0950;
			
			
			
			
			mtr = Convert.ToDouble(txtMetro.Text);
			peso = Convert.ToDouble(txtPrecio.Text);
			precio=Convert.ToDouble(txtPrecio.Text);
			
			if(rBtn3.Checked){
				
								
				peso=medida*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				  
				
			}
			else if (rBtn4.Checked){
				
				peso=medida1*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
				
			}
			else if (rBtn5.Checked){
				
				peso=medida2*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
				
			}
			else if (rBtn6.Checked){
				
				peso=medida3*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
				
			}
			else if (rBtn7.Checked){
				
				peso=medida4*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
				
			}
			else if (rBtn8.Checked){
				
				peso=medida5*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
			
			}
			else if (rBtn9.Checked){
				
				peso=medida6*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
			}
			else if (rBtn10.Checked){
				
				peso=medida7*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto=precio+iva;
				
				
			}
			
			label3.Text = "Peso:                             "+peso.ToString(".00");                /** Imprime Los Precios**/
				label5.Text = "Metro:                           "+txtMetro.Text;
				label6.Text = "Precio:                         $"+precio.ToString(".00");
				label7.Text = "Iva:                                $"+iva.ToString(".00");
				label8.Text = "Precio Neto:              $"+neto.ToString(".00");
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			imprimir_solicitud();
		}
	}
}
