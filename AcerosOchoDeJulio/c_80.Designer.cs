/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 30/05/2014
 * Time: 12:48 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AcerosOchoDeJulio
{
	partial class c_80
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(c_80));
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.richTextPresupuesto = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMetro = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.rd2 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.lbprecioneto = new System.Windows.Forms.Label();
			this.lbiva = new System.Windows.Forms.Label();
			this.lbprecio = new System.Windows.Forms.Label();
			this.lbmetro = new System.Windows.Forms.Label();
			this.lbpeso = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbempresa = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(-44, 596);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(716, 15);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 30;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(24, 50);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(200, 15);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 29;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(401, 50);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(200, 15);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 28;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(230, 33);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(165, 46);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 27;
			this.pictureBox1.TabStop = false;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(510, 548);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(81, 30);
			this.btnAceptar.TabIndex = 26;
			this.btnAceptar.Text = "Cerrar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(310, 480);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(107, 46);
			this.btnCalcular.TabIndex = 25;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// richTextPresupuesto
			// 
			this.richTextPresupuesto.Location = new System.Drawing.Point(266, 181);
			this.richTextPresupuesto.Name = "richTextPresupuesto";
			this.richTextPresupuesto.Size = new System.Drawing.Size(325, 293);
			this.richTextPresupuesto.TabIndex = 24;
			this.richTextPresupuesto.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(44, 412);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 28);
			this.label4.TabIndex = 23;
			this.label4.Text = "Metro";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(44, 332);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 28);
			this.label2.TabIndex = 21;
			this.label2.Text = "Precio";
			// 
			// txtMetro
			// 
			this.txtMetro.Location = new System.Drawing.Point(44, 443);
			this.txtMetro.Name = "txtMetro";
			this.txtMetro.Size = new System.Drawing.Size(198, 31);
			this.txtMetro.TabIndex = 19;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(44, 363);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(198, 31);
			this.txtPrecio.TabIndex = 18;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(434, 480);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 46);
			this.button1.TabIndex = 31;
			this.button1.Text = "Imprimir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// rd2
			// 
			this.rd2.Location = new System.Drawing.Point(44, 241);
			this.rd2.Name = "rd2";
			this.rd2.Size = new System.Drawing.Size(104, 24);
			this.rd2.TabIndex = 33;
			this.rd2.TabStop = true;
			this.rd2.Text = "2\'";
			this.rd2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(44, 184);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 28);
			this.label1.TabIndex = 32;
			this.label1.Text = "Ancho";
			// 
			// lbprecioneto
			// 
			this.lbprecioneto.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbprecioneto.Location = new System.Drawing.Point(286, 431);
			this.lbprecioneto.Name = "lbprecioneto";
			this.lbprecioneto.Size = new System.Drawing.Size(292, 23);
			this.lbprecioneto.TabIndex = 178;
			// 
			// lbiva
			// 
			this.lbiva.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbiva.Location = new System.Drawing.Point(286, 394);
			this.lbiva.Name = "lbiva";
			this.lbiva.Size = new System.Drawing.Size(292, 23);
			this.lbiva.TabIndex = 177;
			// 
			// lbprecio
			// 
			this.lbprecio.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbprecio.Location = new System.Drawing.Point(286, 356);
			this.lbprecio.Name = "lbprecio";
			this.lbprecio.Size = new System.Drawing.Size(292, 23);
			this.lbprecio.TabIndex = 176;
			// 
			// lbmetro
			// 
			this.lbmetro.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbmetro.Location = new System.Drawing.Point(286, 322);
			this.lbmetro.Name = "lbmetro";
			this.lbmetro.Size = new System.Drawing.Size(292, 23);
			this.lbmetro.TabIndex = 175;
			// 
			// lbpeso
			// 
			this.lbpeso.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbpeso.Location = new System.Drawing.Point(286, 285);
			this.lbpeso.Name = "lbpeso";
			this.lbpeso.Size = new System.Drawing.Size(292, 23);
			this.lbpeso.TabIndex = 174;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(472, 225);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(106, 23);
			this.label6.TabIndex = 173;
			this.label6.Text = "Tel. 36193663";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(286, 225);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(180, 23);
			this.label5.TabIndex = 172;
			this.label5.Text = "Avenida 8 de Julio #1671";
			// 
			// lbempresa
			// 
			this.lbempresa.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbempresa.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbempresa.Location = new System.Drawing.Point(349, 199);
			this.lbempresa.Name = "lbempresa";
			this.lbempresa.Size = new System.Drawing.Size(170, 27);
			this.lbempresa.TabIndex = 171;
			this.lbempresa.Text = "\"Aceros 8 de Julio\"";
			// 
			// c_80
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(629, 636);
			this.Controls.Add(this.lbprecioneto);
			this.Controls.Add(this.lbiva);
			this.Controls.Add(this.lbprecio);
			this.Controls.Add(this.lbmetro);
			this.Controls.Add(this.lbpeso);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lbempresa);
			this.Controls.Add(this.rd2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.richTextPresupuesto);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMetro);
			this.Controls.Add(this.txtPrecio);
			this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "c_80";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "c_80";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lbempresa;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbpeso;
		private System.Windows.Forms.Label lbmetro;
		private System.Windows.Forms.Label lbprecio;
		private System.Windows.Forms.Label lbiva;
		private System.Windows.Forms.Label lbprecioneto;
		private System.Windows.Forms.RadioButton rd2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtMetro;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox richTextPresupuesto;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox4;
	}
}
