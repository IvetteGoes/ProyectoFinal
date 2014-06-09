/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 30/05/2014
 * Time: 10:43 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public partial class Menu : Form
	{
		public Menu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		BuscarMaterial s = new BuscarMaterial();
		
		void ToolStripMenuItem2Click(object sender, EventArgs e)
		{
			angulo_1_8 abrir = new angulo_1_8();
			abrir.Show();
			this.Hide();
		}
		
		void ToolStripMenuItem3Click(object sender, EventArgs e)
		{
			angulo_3_16 abrir = new angulo_3_16();
			abrir.Show();
			this.Hide();
		}
		
		void ToolStripMenuItem4Click(object sender, EventArgs e)
		{
			angulo_1_4 abrir = new angulo_1_4();
			abrir.Show();
			this.Hide();
		}
		
		void ToolStripMenuItem5Click(object sender, EventArgs e)
		{
			angulo_3_8 abrir = new angulo_3_8();
			abrir.Show();
			this.Hide();
		}
		
		void ToolStripMenuItem6Click(object sender, EventArgs e)
		{
			angulo_1_2 abrir = new angulo_1_2();
			abrir.Show();
			this.Hide();
		}
		
		void ToolStripMenuItem7Click(object sender, EventArgs e)
		{
			angulo_5_8 abrir = new angulo_5_8();
			abrir.Show();
			this.Hide();
		}
		
		void ToolStripMenuItem8Click(object sender, EventArgs e)
		{
			angulo_3_4 abrir = new angulo_3_4();
			abrir.Show();
			this.Hide();
		}
		
		void CToolStripMenuItemClick(object sender, EventArgs e)
		{
			cuadrados abrir = new cuadrados();
			abrir.Show();
			this.Hide();
		}
		
		void ColdRollToolStripMenuItemClick(object sender, EventArgs e)
		{
			cold_roll abrir = new cold_roll();
			abrir.Show();
			this.Hide();
		}
		
		void CPSCanalUToolStripMenuItemClick(object sender, EventArgs e)
		{
			cps_canal_u abrir = new cps_canal_u();
			abrir.Show();
			this.Hide();
		}
		
		void C13MmToolStripMenuItemClick(object sender, EventArgs e)
		{
			c_10_013mm abrir = new c_10_013mm();
			abrir.Show();
			this.Hide();
		}
		
		void C14MmToolStripMenuItemClick(object sender, EventArgs e)
		{
			c_14_074mm abrir = new c_14_074mm();
			abrir.Show();
			this.Hide();
		}
		
		void C120104mmToolStripMenuItemClick(object sender, EventArgs e)
		{
			c_12_104mm abrir = new c_12_104mm();
			abrir.Show();
			this.Hide();
		}
		
		void ToolStripMenuItem9Click(object sender, EventArgs e)
		{
			_1_8_125mm abrir = new _1_8_125mm();
			abrir.Show();
			this.Hide();
		}
		
		void ToolStripMenuItem10Click(object sender, EventArgs e)
		{
			_3_16_187mm abrir = new _3_16_187mm();
			abrir.Show();
			this.Hide();
		}
		
		void MmToolStripMenuItemClick(object sender, EventArgs e)
		{
			_1_4_250mm abrir = new _1_4_250mm();
			abrir.Show();
			this.Hide();
		}
		
		void LaminaC16ToolStripMenuItemClick(object sender, EventArgs e)
		{
			lamina_c_16 abrir = new lamina_c_16();
			abrir.Show();
			this.Hide();
		}
		
		void LaminaC18ToolStripMenuItemClick(object sender, EventArgs e)
		{
			lamina_c_18 abrir = new lamina_c_18();
			abrir.Show();
			this.Hide();
		}
		
		void LaminaC20ToolStripMenuItemClick(object sender, EventArgs e)
		{
			lamina_c_20 abrir = new lamina_c_20();
			abrir.Show();
			this.Hide();
		}
		
		void LaminaC26ToolStripMenuItemClick(object sender, EventArgs e)
		{
			lamina_c_20 abrir = new lamina_c_20();
			abrir.Show();
			this.Hide();
		}
		
		void LaminaC10ToolStripMenuItemClick(object sender, EventArgs e)
		{
			lamina_c_10 abrir = new lamina_c_10();
			abrir.Show();
			this.Hide();
		}
		
		void LaminaC12ToolStripMenuItemClick(object sender, EventArgs e)
		{
			lamina_c_12 abrir = new lamina_c_12();
			abrir.Show();
			this.Hide();
		}
		
		void LaminaC14ToolStripMenuItemClick(object sender, EventArgs e)
		{
			lamina_c_14 abrir = new lamina_c_14();
			abrir.Show();
			this.Hide();
		}
		
		void AzulC14ToolStripMenuItemClick(object sender, EventArgs e)
		{
			azul_c_14 abrir = new azul_c_14();
			abrir.Show();
			this.Hide();
		}
		
		void BlancoToolStripMenuItemClick(object sender, EventArgs e)
		{
			blanco abrir = new blanco();
			abrir.Show();
			this.Hide();
		}
		
		void VerdeToolStripMenuItemClick(object sender, EventArgs e)
		{
			verde abrir = new verde();
			abrir.Show();
			this.Hide();
		}
		
		void RojoToolStripMenuItemClick(object sender, EventArgs e)
		{
			rojo abrir = new rojo();
			abrir.Show();
			this.Hide();
		}
		
		void RedondosToolStripMenuItemClick(object sender, EventArgs e)
		{
			redondos abrir =  new redondos();
			abrir.Show();
			this.Hide();
		}
		
		void C30ToolStripMenuItemClick(object sender, EventArgs e)
		{
			c_30 abrir = new c_30();
			abrir.Show();
			this.Hide();
		}
		
		void C40ToolStripMenuItemClick(object sender, EventArgs e)
		{
			c_40 abrir = new c_40();
			abrir.Show();
			this.Hide();
		}
		
		void C80ToolStripMenuItemClick(object sender, EventArgs e)
		{
			c_80 abrir = new c_80();
			abrir.Show();
			this.Hide();
		}
		
		void ToolStripMenuItem11Click(object sender, EventArgs e)
		{
			solera_1_8 abrir = new solera_1_8();
			abrir.Show();
			this.Hide();
		}
		
		void ToolStripMenuItem12Click(object sender, EventArgs e)
		{
			solera_3_16 abrir = new solera_3_16();
			abrir.Show();
			this.Hide();
		}
		
		void ToolStripMenuItem13Click(object sender, EventArgs e)
		{
			solera_1_4 abir = new solera_1_4();
			abir.Show();
			this.Hide();
		}
		
		void ToolStripMenuItem14Click(object sender, EventArgs e)
		{
			solera_5_16 abrir = new solera_5_16();
			abrir.Show();
			this.Hide();
		}
		
		void ToolStripMenuItem15Click(object sender, EventArgs e)
		{
			solera_3_8 abrir = new solera_3_8();
			abrir.Show();
			this.Hide();
		}
		
		void ToolStripMenuItem16Click(object sender, EventArgs e)
		{
			solera_1_2 abrir = new solera_1_2();
			abrir.Show();
			this.Hide();
		}
		
		void ToolStripMenuItem17Click(object sender, EventArgs e)
		{
			solera_5_8 abir = new solera_5_8();
			abir.Show();
			this.Hide();
		}
		
		void ToolStripMenuItem18Click(object sender, EventArgs e)
		{
			solera_3_4 abrir = new solera_3_4();
			abrir.Show();
			this.Hide();
		}
		
		void ToolStripMenuItem19Click(object sender, EventArgs e)
		{
			solera_1 abrir = new solera_1();
			abrir.Show();
			this.Hide();
			
		}
		
		void TuberiaEnDiametrosMayoresToolStripMenuItemClick(object sender, EventArgs e)
		{
			tuberia_diametros_mayores abrir = new tuberia_diametros_mayores();
			abrir.Show();
			this.Hide();
		}
		
		void TubularToolStripMenuItemClick(object sender, EventArgs e)
		{
			tubular abrir =  new tubular();
			abrir.Show();
			this.Hide();
		}
		
		void VigaIPSToolStripMenuItemClick(object sender, EventArgs e)
		{
			viga_ips abrir = new viga_ips();
			abrir.Show();
			this.Hide();
		}
		
		void MontenC14ToolStripMenuItemClick(object sender, EventArgs e)
		{
			monten_c_14 abrir = new monten_c_14();
			abrir.Show();
			this.Hide();
		}
		
		void VarillaCorrugadaToolStripMenuItemClick(object sender, EventArgs e)
		{
			varilla_corrugada abrir = new varilla_corrugada();
			abrir.Show();
			this.Hide();
		}
		
		void MaterialToolStripMenuItem5Click(object sender, EventArgs e)
		{
			BuscarMaterial buscar = new BuscarMaterial();
			buscar.ShowDialog();
		}
		
		void MaterialToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Herramientas abrir = new Herramientas();
			abrir.Show();
			this.Hide();
		}
		
		void MenuFormClosed(object sender, FormClosedEventArgs e)
		{
			System.Environment.Exit(0);
		}
		
		void ClientesToolStripMenuItemClick(object sender, EventArgs e)
		{
			CHerramientas abrir = new CHerramientas();
			abrir.Show();
			this.Hide();
		}
		
		void EmpleadosToolStripMenuItemClick(object sender, EventArgs e)
		{
			agregar_Usuario abrir = new agregar_Usuario();
			abrir.Show();
			this.Hide();
		}
		
		void ProvedoresToolStripMenuItemClick(object sender, EventArgs e)
		{
			proveedor abrir = new proveedor();
			abrir.Show();
			this.Hide();
		}
	}
}
