/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 30/05/2014
 * Time: 11:54 a. m.
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
	/// Description of cold_roll.
	/// </summary>
	public partial class cold_roll : Form
	{
		public cold_roll()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
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
					empresa = lblEmpresa.Text;
					peso = lblPeso.Text;
					metro = lblMetro.Text;
					precio = lblPrecio.Text;
					iva = lblIva.Text;
					neto = lblNeto.Text;
					

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
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			Menu abrir = new Menu();
			abrir.Show();
			this.Hide();
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double neto,peso,iva,precio, medida,medida2,medida3,medida4,medida5,medida6,medida7,medida8, medida9, medida10, mtr;
        	//decimal dec1;
        	neto=0.0;
			peso=0.0;
			iva=0.0;
			medida=.0131;
			medida2=.0163;
			medida3=.0229;
			medida4=.0311;
			medida5=.0393;
			medida6=.0622;
			medida7=.0901;
			medida8=.0121;
			medida9=.1590;
			medida10=.2491;
			
			
			mtr = Convert.ToDouble(txtMetro.Text); //se convierte string a double usando--> Convert.ToDouble(txt.text)
			precio = Convert.ToDouble(txtPrecio.Text);
			
			if(rdb1.Checked)
			{
				peso= medida*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto= precio+iva;
				lblPeso.Text="Peso: "+peso.ToString(".00");
				lblMetro.Text="Metro: "+txtMetro.Text;
				lblPrecio.Text="Precio: $"+precio.ToString(".00");
				lblIva.Text="Iva: $"+iva.ToString(".00");
				lblNeto.Text="Precio neto: $"+neto.ToString(".00");
			}
			else if(rdb2.Checked)
			{
				peso= medida2*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto= precio+iva;
				lblPeso.Text="Peso: "+peso.ToString(".00");
				lblMetro.Text="Metro: "+txtMetro.Text;
				lblPrecio.Text="Precio: $"+precio.ToString(".00");
				lblIva.Text="Iva: $"+iva.ToString(".00");
				lblNeto.Text="Precio neto: $"+neto.ToString(".00");
			}
			else if(rdb3.Checked)
			{
				peso= medida3*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto= precio+iva;
				lblPeso.Text="Peso: "+peso.ToString(".00");
				lblMetro.Text="Metro: "+txtMetro.Text;
				lblPrecio.Text="Precio: $"+precio.ToString(".00");
				lblIva.Text="Iva: $"+iva.ToString(".00");
				lblNeto.Text="Precio neto: $"+neto.ToString(".00");
			}
			else if (rdb4.Checked)
			{
				peso= medida4*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto= precio+iva;
				lblPeso.Text="Peso: "+peso.ToString(".00");
				lblMetro.Text="Metro: "+txtMetro.Text;
				lblPrecio.Text="Precio: $"+precio.ToString(".00");
				lblIva.Text="Iva: $"+iva.ToString(".00");
				lblNeto.Text="Precio neto: $"+neto.ToString(".00");
			}
			else if (rdb5.Checked)
			{
				peso= medida5*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto= precio+iva;
				lblPeso.Text="Peso: "+peso.ToString(".00");
				lblMetro.Text="Metro: "+txtMetro.Text;
				lblPrecio.Text="Precio: $"+precio.ToString(".00");
				lblIva.Text="Iva: $"+iva.ToString(".00");
				lblNeto.Text="Precio neto: $"+neto.ToString(".00");
			}
			else if (rdb6.Checked)
			{
				peso= medida6*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto= precio+iva;
				lblPeso.Text="Peso: "+peso.ToString(".00");
				lblMetro.Text="Metro: "+txtMetro.Text;
				lblPrecio.Text="Precio: $"+precio.ToString(".00");
				lblIva.Text="Iva: $"+iva.ToString(".00");
				lblNeto.Text="Precio neto: $"+neto.ToString(".00");
			}
			else if (rdb7.Checked)
			{
				peso= medida7*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto= precio+iva;
				lblPeso.Text="Peso: "+peso.ToString(".00");
				lblMetro.Text="Metro: "+txtMetro.Text;
				lblPrecio.Text="Precio: $"+precio.ToString(".00");
				lblIva.Text="Iva: $"+iva.ToString(".00");
				lblNeto.Text="Precio neto: $"+neto.ToString(".00");
			}
			else if (rdb8.Checked)
			{
				peso= medida8*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto= precio+iva;
				lblPeso.Text="Peso: "+peso.ToString(".00");
				lblMetro.Text="Metro: "+txtMetro.Text;
				lblPrecio.Text="Precio: $"+precio.ToString(".00");
				lblIva.Text="Iva: $"+iva.ToString(".00");
				lblNeto.Text="Precio neto: $"+neto.ToString(".00");
			}
			else if (rdb9.Checked)
			{
				peso= medida9*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto= precio+iva;
				lblPeso.Text="Peso: "+peso.ToString(".00");
				lblMetro.Text="Metro: "+txtMetro.Text;
				lblPrecio.Text="Precio: $"+precio.ToString(".00");
				lblIva.Text="Iva: $"+iva.ToString(".00");
				lblNeto.Text="Precio neto: $"+neto.ToString(".00");
			}
			else if (rdb10.Checked)
			{
				peso= medida10*mtr;
				precio=peso*precio;
				iva=precio*.16;
				neto= precio+iva;
				lblPeso.Text="Peso: "+peso.ToString(".00");
				lblMetro.Text="Metro: "+txtMetro.Text;
				lblPrecio.Text="Precio: $"+precio.ToString(".00");
				lblIva.Text="Iva: $"+iva.ToString(".00");
				lblNeto.Text="Precio neto: $"+neto.ToString(".00");
			}
			this.txtMetro.Clear();
			this.txtPrecio.Clear();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			imprimir_solicitud();
		}
	}
}
