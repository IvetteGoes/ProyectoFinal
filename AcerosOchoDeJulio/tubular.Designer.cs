/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 30/05/2014
 * Time: 01:09 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AcerosOchoDeJulio
{
	partial class tubular
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tubular));
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.richTextPresupuesto = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.rb4x112 = new System.Windows.Forms.RadioButton();
			this.rb3x112 = new System.Windows.Forms.RadioButton();
			this.rb212x114 = new System.Windows.Forms.RadioButton();
			this.rb212x112 = new System.Windows.Forms.RadioButton();
			this.rb214x34 = new System.Windows.Forms.RadioButton();
			this.rb2x1 = new System.Windows.Forms.RadioButton();
			this.rb134x34 = new System.Windows.Forms.RadioButton();
			this.rb112x12 = new System.Windows.Forms.RadioButton();
			this.rb114x34 = new System.Windows.Forms.RadioButton();
			this.rb1x12 = new System.Windows.Forms.RadioButton();
			this.rb2 = new System.Windows.Forms.RadioButton();
			this.rb112 = new System.Windows.Forms.RadioButton();
			this.rb114 = new System.Windows.Forms.RadioButton();
			this.rb1 = new System.Windows.Forms.RadioButton();
			this.rb34 = new System.Windows.Forms.RadioButton();
			this.rb12 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbEmpresa = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.lbNeto = new System.Windows.Forms.Label();
			this.lbIva = new System.Windows.Forms.Label();
			this.lbPrecio = new System.Windows.Forms.Label();
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
			this.pictureBox2.Location = new System.Drawing.Point(24, 42);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(200, 15);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 29;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(401, 42);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(200, 15);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 28;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(230, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(165, 46);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 27;
			this.pictureBox1.TabStop = false;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(494, 540);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(88, 38);
			this.btnAceptar.TabIndex = 26;
			this.btnAceptar.Text = "Cerrar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(313, 443);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(107, 46);
			this.btnCalcular.TabIndex = 25;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// richTextPresupuesto
			// 
			this.richTextPresupuesto.Location = new System.Drawing.Point(276, 123);
			this.richTextPresupuesto.Name = "richTextPresupuesto";
			this.richTextPresupuesto.Size = new System.Drawing.Size(325, 293);
			this.richTextPresupuesto.TabIndex = 24;
			this.richTextPresupuesto.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 412);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 28);
			this.label2.TabIndex = 21;
			this.label2.Text = "Precio";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(24, 443);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(198, 31);
			this.txtPrecio.TabIndex = 18;
			// 
			// rb4x112
			// 
			this.rb4x112.Location = new System.Drawing.Point(142, 346);
			this.rb4x112.Name = "rb4x112";
			this.rb4x112.Size = new System.Drawing.Size(104, 24);
			this.rb4x112.TabIndex = 64;
			this.rb4x112.TabStop = true;
			this.rb4x112.Text = "4\"x1\"1/2";
			this.rb4x112.UseVisualStyleBackColor = true;
			// 
			// rb3x112
			// 
			this.rb3x112.Location = new System.Drawing.Point(16, 340);
			this.rb3x112.Name = "rb3x112";
			this.rb3x112.Size = new System.Drawing.Size(104, 30);
			this.rb3x112.TabIndex = 63;
			this.rb3x112.TabStop = true;
			this.rb3x112.Text = "3\"x1\"1/2";
			this.rb3x112.UseVisualStyleBackColor = true;
			// 
			// rb212x114
			// 
			this.rb212x114.Location = new System.Drawing.Point(16, 310);
			this.rb212x114.Name = "rb212x114";
			this.rb212x114.Size = new System.Drawing.Size(119, 24);
			this.rb212x114.TabIndex = 62;
			this.rb212x114.TabStop = true;
			this.rb212x114.Text = "2\"1/2x1\"1/4";
			this.rb212x114.UseVisualStyleBackColor = true;
			// 
			// rb212x112
			// 
			this.rb212x112.Location = new System.Drawing.Point(141, 310);
			this.rb212x112.Name = "rb212x112";
			this.rb212x112.Size = new System.Drawing.Size(118, 24);
			this.rb212x112.TabIndex = 61;
			this.rb212x112.TabStop = true;
			this.rb212x112.Text = "2\"1/2x1\"1/2";
			this.rb212x112.UseVisualStyleBackColor = true;
			// 
			// rb214x34
			// 
			this.rb214x34.Location = new System.Drawing.Point(141, 274);
			this.rb214x34.Name = "rb214x34";
			this.rb214x34.Size = new System.Drawing.Size(110, 36);
			this.rb214x34.TabIndex = 60;
			this.rb214x34.TabStop = true;
			this.rb214x34.Text = "2\"1/4x3/4";
			this.rb214x34.UseVisualStyleBackColor = true;
			// 
			// rb2x1
			// 
			this.rb2x1.Location = new System.Drawing.Point(17, 280);
			this.rb2x1.Name = "rb2x1";
			this.rb2x1.Size = new System.Drawing.Size(104, 24);
			this.rb2x1.TabIndex = 59;
			this.rb2x1.TabStop = true;
			this.rb2x1.Text = "2\"x1\"";
			this.rb2x1.UseVisualStyleBackColor = true;
			// 
			// rb134x34
			// 
			this.rb134x34.Location = new System.Drawing.Point(142, 242);
			this.rb134x34.Name = "rb134x34";
			this.rb134x34.Size = new System.Drawing.Size(110, 40);
			this.rb134x34.TabIndex = 58;
			this.rb134x34.TabStop = true;
			this.rb134x34.Text = "1\"3/4x 3/4";
			this.rb134x34.UseVisualStyleBackColor = true;
			// 
			// rb112x12
			// 
			this.rb112x12.Location = new System.Drawing.Point(17, 250);
			this.rb112x12.Name = "rb112x12";
			this.rb112x12.Size = new System.Drawing.Size(104, 24);
			this.rb112x12.TabIndex = 57;
			this.rb112x12.TabStop = true;
			this.rb112x12.Text = "1\"1/2x1/2";
			this.rb112x12.UseVisualStyleBackColor = true;
			// 
			// rb114x34
			// 
			this.rb114x34.Location = new System.Drawing.Point(141, 211);
			this.rb114x34.Name = "rb114x34";
			this.rb114x34.Size = new System.Drawing.Size(104, 33);
			this.rb114x34.TabIndex = 56;
			this.rb114x34.TabStop = true;
			this.rb114x34.Text = "1\"1/4x3/4";
			this.rb114x34.UseVisualStyleBackColor = true;
			// 
			// rb1x12
			// 
			this.rb1x12.Location = new System.Drawing.Point(16, 220);
			this.rb1x12.Name = "rb1x12";
			this.rb1x12.Size = new System.Drawing.Size(104, 24);
			this.rb1x12.TabIndex = 55;
			this.rb1x12.TabStop = true;
			this.rb1x12.Text = "1\"x1/2";
			this.rb1x12.UseVisualStyleBackColor = true;
			// 
			// rb2
			// 
			this.rb2.Location = new System.Drawing.Point(141, 190);
			this.rb2.Name = "rb2";
			this.rb2.Size = new System.Drawing.Size(48, 24);
			this.rb2.TabIndex = 54;
			this.rb2.TabStop = true;
			this.rb2.Text = "2\"";
			this.rb2.UseVisualStyleBackColor = true;
			// 
			// rb112
			// 
			this.rb112.Location = new System.Drawing.Point(17, 190);
			this.rb112.Name = "rb112";
			this.rb112.Size = new System.Drawing.Size(70, 24);
			this.rb112.TabIndex = 53;
			this.rb112.TabStop = true;
			this.rb112.Text = "1\"1/2";
			this.rb112.UseVisualStyleBackColor = true;
			// 
			// rb114
			// 
			this.rb114.Location = new System.Drawing.Point(141, 160);
			this.rb114.Name = "rb114";
			this.rb114.Size = new System.Drawing.Size(104, 24);
			this.rb114.TabIndex = 52;
			this.rb114.TabStop = true;
			this.rb114.Text = "1\"1/4";
			this.rb114.UseVisualStyleBackColor = true;
			// 
			// rb1
			// 
			this.rb1.Location = new System.Drawing.Point(17, 160);
			this.rb1.Name = "rb1";
			this.rb1.Size = new System.Drawing.Size(104, 24);
			this.rb1.TabIndex = 51;
			this.rb1.TabStop = true;
			this.rb1.Text = "1\"";
			this.rb1.UseVisualStyleBackColor = true;
			// 
			// rb34
			// 
			this.rb34.Location = new System.Drawing.Point(141, 121);
			this.rb34.Name = "rb34";
			this.rb34.Size = new System.Drawing.Size(104, 33);
			this.rb34.TabIndex = 50;
			this.rb34.TabStop = true;
			this.rb34.Text = "3/4";
			this.rb34.UseVisualStyleBackColor = true;
			// 
			// rb12
			// 
			this.rb12.Location = new System.Drawing.Point(17, 130);
			this.rb12.Name = "rb12";
			this.rb12.Size = new System.Drawing.Size(104, 24);
			this.rb12.TabIndex = 49;
			this.rb12.TabStop = true;
			this.rb12.Text = "1/2";
			this.rb12.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 373);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 28);
			this.label1.TabIndex = 48;
			this.label1.Text = "Precio";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(60, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 28);
			this.label3.TabIndex = 47;
			this.label3.Text = "Ancho";
			// 
			// lbEmpresa
			// 
			this.lbEmpresa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbEmpresa.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lbEmpresa.Location = new System.Drawing.Point(363, 153);
			this.lbEmpresa.Name = "lbEmpresa";
			this.lbEmpresa.Size = new System.Drawing.Size(165, 31);
			this.lbEmpresa.TabIndex = 192;
			this.lbEmpresa.Text = "\"Aceros 8 de Julio\"";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.SystemColors.HighlightText;
			this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label11.Location = new System.Drawing.Point(446, 195);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(112, 23);
			this.label11.TabIndex = 191;
			this.label11.Text = "36193663";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.HighlightText;
			this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label12.Location = new System.Drawing.Point(296, 195);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(143, 21);
			this.label12.TabIndex = 190;
			this.label12.Text = "8 de Julio 1671";
			// 
			// lbNeto
			// 
			this.lbNeto.Location = new System.Drawing.Point(291, 352);
			this.lbNeto.Name = "lbNeto";
			this.lbNeto.Size = new System.Drawing.Size(291, 23);
			this.lbNeto.TabIndex = 189;
			// 
			// lbIva
			// 
			this.lbIva.Location = new System.Drawing.Point(291, 313);
			this.lbIva.Name = "lbIva";
			this.lbIva.Size = new System.Drawing.Size(291, 23);
			this.lbIva.TabIndex = 188;
			// 
			// lbPrecio
			// 
			this.lbPrecio.Location = new System.Drawing.Point(291, 277);
			this.lbPrecio.Name = "lbPrecio";
			this.lbPrecio.Size = new System.Drawing.Size(291, 23);
			this.lbPrecio.TabIndex = 187;
			// 
			// lbPeso
			// 
			this.lbPeso.Location = new System.Drawing.Point(291, 240);
			this.lbPeso.Name = "lbPeso";
			this.lbPeso.Size = new System.Drawing.Size(291, 23);
			this.lbPeso.TabIndex = 186;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(446, 443);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 46);
			this.button1.TabIndex = 193;
			this.button1.Text = "Imprimir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// tubular
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
			this.Controls.Add(this.lbPeso);
			this.Controls.Add(this.rb4x112);
			this.Controls.Add(this.rb3x112);
			this.Controls.Add(this.rb212x114);
			this.Controls.Add(this.rb212x112);
			this.Controls.Add(this.rb214x34);
			this.Controls.Add(this.rb2x1);
			this.Controls.Add(this.rb134x34);
			this.Controls.Add(this.rb112x12);
			this.Controls.Add(this.rb114x34);
			this.Controls.Add(this.rb1x12);
			this.Controls.Add(this.rb2);
			this.Controls.Add(this.rb112);
			this.Controls.Add(this.rb114);
			this.Controls.Add(this.rb1);
			this.Controls.Add(this.rb34);
			this.Controls.Add(this.rb12);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.richTextPresupuesto);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPrecio);
			this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "tubular";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "tubular";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lbPeso;
		private System.Windows.Forms.Label lbPrecio;
		private System.Windows.Forms.Label lbIva;
		private System.Windows.Forms.Label lbNeto;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lbEmpresa;
		private System.Windows.Forms.RadioButton rb12;
		private System.Windows.Forms.RadioButton rb34;
		private System.Windows.Forms.RadioButton rb1;
		private System.Windows.Forms.RadioButton rb114;
		private System.Windows.Forms.RadioButton rb112;
		private System.Windows.Forms.RadioButton rb2;
		private System.Windows.Forms.RadioButton rb1x12;
		private System.Windows.Forms.RadioButton rb114x34;
		private System.Windows.Forms.RadioButton rb112x12;
		private System.Windows.Forms.RadioButton rb134x34;
		private System.Windows.Forms.RadioButton rb2x1;
		private System.Windows.Forms.RadioButton rb214x34;
		private System.Windows.Forms.RadioButton rb212x112;
		private System.Windows.Forms.RadioButton rb212x114;
		private System.Windows.Forms.RadioButton rb3x112;
		private System.Windows.Forms.RadioButton rb4x112;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox richTextPresupuesto;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox4;
	}
}
