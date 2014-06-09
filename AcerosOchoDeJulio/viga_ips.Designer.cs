/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 30/05/2014
 * Time: 01:11 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AcerosOchoDeJulio
{
	partial class viga_ips
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viga_ips));
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
			this.rb101 = new System.Windows.Forms.RadioButton();
			this.rb12 = new System.Windows.Forms.RadioButton();
			this.rb8 = new System.Windows.Forms.RadioButton();
			this.rb6 = new System.Windows.Forms.RadioButton();
			this.rb5 = new System.Windows.Forms.RadioButton();
			this.rb4 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.lbEmpresa = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.lbNeto = new System.Windows.Forms.Label();
			this.lbIva = new System.Windows.Forms.Label();
			this.lbPrecio = new System.Windows.Forms.Label();
			this.lbMetro = new System.Windows.Forms.Label();
			this.lbPeso = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
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
			this.pictureBox2.Location = new System.Drawing.Point(26, 44);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(200, 15);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 29;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(403, 44);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(200, 15);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 28;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(232, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(165, 46);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 27;
			this.pictureBox1.TabStop = false;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(526, 558);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(91, 32);
			this.btnAceptar.TabIndex = 26;
			this.btnAceptar.Text = "Cerrar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(310, 497);
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
			this.label4.Location = new System.Drawing.Point(28, 416);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 28);
			this.label4.TabIndex = 23;
			this.label4.Text = "Metro";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(28, 351);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 28);
			this.label2.TabIndex = 21;
			this.label2.Text = "Precio";
			// 
			// txtMetro
			// 
			this.txtMetro.Location = new System.Drawing.Point(28, 447);
			this.txtMetro.Name = "txtMetro";
			this.txtMetro.Size = new System.Drawing.Size(198, 31);
			this.txtMetro.TabIndex = 19;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(28, 382);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(198, 31);
			this.txtPrecio.TabIndex = 18;
			// 
			// rb101
			// 
			this.rb101.Location = new System.Drawing.Point(99, 246);
			this.rb101.Name = "rb101";
			this.rb101.Size = new System.Drawing.Size(104, 24);
			this.rb101.TabIndex = 45;
			this.rb101.TabStop = true;
			this.rb101.Text = "10\"";
			this.rb101.UseVisualStyleBackColor = true;
			// 
			// rb12
			// 
			this.rb12.Location = new System.Drawing.Point(99, 274);
			this.rb12.Name = "rb12";
			this.rb12.Size = new System.Drawing.Size(104, 24);
			this.rb12.TabIndex = 44;
			this.rb12.TabStop = true;
			this.rb12.Text = "12\"";
			this.rb12.UseVisualStyleBackColor = true;
			// 
			// rb8
			// 
			this.rb8.Location = new System.Drawing.Point(99, 215);
			this.rb8.Name = "rb8";
			this.rb8.Size = new System.Drawing.Size(104, 24);
			this.rb8.TabIndex = 43;
			this.rb8.TabStop = true;
			this.rb8.Text = "8\"";
			this.rb8.UseVisualStyleBackColor = true;
			// 
			// rb6
			// 
			this.rb6.Location = new System.Drawing.Point(39, 274);
			this.rb6.Name = "rb6";
			this.rb6.Size = new System.Drawing.Size(104, 24);
			this.rb6.TabIndex = 42;
			this.rb6.TabStop = true;
			this.rb6.Text = "6\"";
			this.rb6.UseVisualStyleBackColor = true;
			// 
			// rb5
			// 
			this.rb5.Location = new System.Drawing.Point(39, 242);
			this.rb5.Name = "rb5";
			this.rb5.Size = new System.Drawing.Size(54, 26);
			this.rb5.TabIndex = 41;
			this.rb5.TabStop = true;
			this.rb5.Text = "5\"";
			this.rb5.UseVisualStyleBackColor = true;
			// 
			// rb4
			// 
			this.rb4.Location = new System.Drawing.Point(39, 212);
			this.rb4.Name = "rb4";
			this.rb4.Size = new System.Drawing.Size(104, 24);
			this.rb4.TabIndex = 40;
			this.rb4.TabStop = true;
			this.rb4.Text = "4\"";
			this.rb4.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(39, 181);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 28);
			this.label1.TabIndex = 39;
			this.label1.Text = "Ancho";
			// 
			// lbEmpresa
			// 
			this.lbEmpresa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbEmpresa.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lbEmpresa.Location = new System.Drawing.Point(358, 191);
			this.lbEmpresa.Name = "lbEmpresa";
			this.lbEmpresa.Size = new System.Drawing.Size(166, 31);
			this.lbEmpresa.TabIndex = 193;
			this.lbEmpresa.Text = "\"Aceros 8 de Julio\"";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.SystemColors.HighlightText;
			this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label11.Location = new System.Drawing.Point(441, 230);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(93, 23);
			this.label11.TabIndex = 192;
			this.label11.Text = "36193663";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.HighlightText;
			this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label12.Location = new System.Drawing.Point(291, 230);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(124, 21);
			this.label12.TabIndex = 191;
			this.label12.Text = "8 de Julio 1671";
			// 
			// lbNeto
			// 
			this.lbNeto.Location = new System.Drawing.Point(286, 431);
			this.lbNeto.Name = "lbNeto";
			this.lbNeto.Size = new System.Drawing.Size(272, 23);
			this.lbNeto.TabIndex = 190;
			// 
			// lbIva
			// 
			this.lbIva.Location = new System.Drawing.Point(286, 392);
			this.lbIva.Name = "lbIva";
			this.lbIva.Size = new System.Drawing.Size(272, 23);
			this.lbIva.TabIndex = 189;
			// 
			// lbPrecio
			// 
			this.lbPrecio.Location = new System.Drawing.Point(286, 352);
			this.lbPrecio.Name = "lbPrecio";
			this.lbPrecio.Size = new System.Drawing.Size(272, 23);
			this.lbPrecio.TabIndex = 188;
			// 
			// lbMetro
			// 
			this.lbMetro.Location = new System.Drawing.Point(286, 313);
			this.lbMetro.Name = "lbMetro";
			this.lbMetro.Size = new System.Drawing.Size(272, 23);
			this.lbMetro.TabIndex = 187;
			// 
			// lbPeso
			// 
			this.lbPeso.Location = new System.Drawing.Point(286, 275);
			this.lbPeso.Name = "lbPeso";
			this.lbPeso.Size = new System.Drawing.Size(272, 23);
			this.lbPeso.TabIndex = 186;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(441, 497);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 46);
			this.button1.TabIndex = 194;
			this.button1.Text = "Imprimir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// viga_ips
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(629, 636);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lbEmpresa);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.lbNeto);
			this.Controls.Add(this.lbIva);
			this.Controls.Add(this.lbPrecio);
			this.Controls.Add(this.lbMetro);
			this.Controls.Add(this.lbPeso);
			this.Controls.Add(this.rb101);
			this.Controls.Add(this.rb12);
			this.Controls.Add(this.rb8);
			this.Controls.Add(this.rb6);
			this.Controls.Add(this.rb5);
			this.Controls.Add(this.rb4);
			this.Controls.Add(this.label1);
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
			this.Name = "viga_ips";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "viga_ips";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lbPeso;
		private System.Windows.Forms.Label lbMetro;
		private System.Windows.Forms.Label lbPrecio;
		private System.Windows.Forms.Label lbIva;
		private System.Windows.Forms.Label lbNeto;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lbEmpresa;
		private System.Windows.Forms.RadioButton rb4;
		private System.Windows.Forms.RadioButton rb5;
		private System.Windows.Forms.RadioButton rb6;
		private System.Windows.Forms.RadioButton rb8;
		private System.Windows.Forms.RadioButton rb12;
		private System.Windows.Forms.RadioButton rb101;
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
