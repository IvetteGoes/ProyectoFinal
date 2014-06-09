/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 30/05/2014
 * Time: 11:35 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AcerosOchoDeJulio
{
	partial class angulo_1_4
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(angulo_1_4));
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
			this.label1 = new System.Windows.Forms.Label();
			this.rdb1 = new System.Windows.Forms.RadioButton();
			this.rdb2 = new System.Windows.Forms.RadioButton();
			this.rdb5 = new System.Windows.Forms.RadioButton();
			this.rdb7 = new System.Windows.Forms.RadioButton();
			this.rdb8 = new System.Windows.Forms.RadioButton();
			this.rdb6 = new System.Windows.Forms.RadioButton();
			this.rdb4 = new System.Windows.Forms.RadioButton();
			this.rdb3 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.lblEmpresa = new System.Windows.Forms.Label();
			this.lblNeto = new System.Windows.Forms.Label();
			this.lblIva = new System.Windows.Forms.Label();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.lblMetro = new System.Windows.Forms.Label();
			this.lblPeso = new System.Windows.Forms.Label();
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
			this.pictureBox2.Location = new System.Drawing.Point(26, 43);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(200, 15);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 29;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(403, 43);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(200, 15);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 28;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(232, 26);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(165, 46);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 27;
			this.pictureBox1.TabStop = false;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(510, 550);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(81, 31);
			this.btnAceptar.TabIndex = 26;
			this.btnAceptar.Text = "Cerrar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(308, 484);
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
			this.label4.Location = new System.Drawing.Point(37, 409);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 28);
			this.label4.TabIndex = 23;
			this.label4.Text = "Centimetros";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(37, 337);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 28);
			this.label2.TabIndex = 21;
			this.label2.Text = "Precio";
			// 
			// txtMetro
			// 
			this.txtMetro.Location = new System.Drawing.Point(37, 440);
			this.txtMetro.Name = "txtMetro";
			this.txtMetro.Size = new System.Drawing.Size(198, 31);
			this.txtMetro.TabIndex = 19;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(37, 368);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(198, 31);
			this.txtPrecio.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(77, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 28);
			this.label1.TabIndex = 17;
			this.label1.Text = "Ancho";
			// 
			// rdb1
			// 
			this.rdb1.Location = new System.Drawing.Point(26, 112);
			this.rdb1.Name = "rdb1";
			this.rdb1.Size = new System.Drawing.Size(104, 24);
			this.rdb1.TabIndex = 31;
			this.rdb1.TabStop = true;
			this.rdb1.Text = "1\"";
			this.rdb1.UseVisualStyleBackColor = true;
			// 
			// rdb2
			// 
			this.rdb2.Location = new System.Drawing.Point(26, 151);
			this.rdb2.Name = "rdb2";
			this.rdb2.Size = new System.Drawing.Size(104, 24);
			this.rdb2.TabIndex = 32;
			this.rdb2.TabStop = true;
			this.rdb2.Text = "1\" 1/2";
			this.rdb2.UseVisualStyleBackColor = true;
			// 
			// rdb5
			// 
			this.rdb5.Location = new System.Drawing.Point(142, 112);
			this.rdb5.Name = "rdb5";
			this.rdb5.Size = new System.Drawing.Size(104, 24);
			this.rdb5.TabIndex = 33;
			this.rdb5.TabStop = true;
			this.rdb5.Text = "2\" 1/2";
			this.rdb5.UseVisualStyleBackColor = true;
			// 
			// rdb7
			// 
			this.rdb7.Location = new System.Drawing.Point(142, 200);
			this.rdb7.Name = "rdb7";
			this.rdb7.Size = new System.Drawing.Size(104, 24);
			this.rdb7.TabIndex = 34;
			this.rdb7.TabStop = true;
			this.rdb7.Text = "3\" 1/2";
			this.rdb7.UseVisualStyleBackColor = true;
			// 
			// rdb8
			// 
			this.rdb8.Location = new System.Drawing.Point(142, 247);
			this.rdb8.Name = "rdb8";
			this.rdb8.Size = new System.Drawing.Size(104, 24);
			this.rdb8.TabIndex = 38;
			this.rdb8.TabStop = true;
			this.rdb8.Text = "4\"";
			this.rdb8.UseVisualStyleBackColor = true;
			// 
			// rdb6
			// 
			this.rdb6.Location = new System.Drawing.Point(142, 151);
			this.rdb6.Name = "rdb6";
			this.rdb6.Size = new System.Drawing.Size(104, 24);
			this.rdb6.TabIndex = 37;
			this.rdb6.TabStop = true;
			this.rdb6.Text = "3\"";
			this.rdb6.UseVisualStyleBackColor = true;
			// 
			// rdb4
			// 
			this.rdb4.Location = new System.Drawing.Point(26, 247);
			this.rdb4.Name = "rdb4";
			this.rdb4.Size = new System.Drawing.Size(104, 24);
			this.rdb4.TabIndex = 36;
			this.rdb4.TabStop = true;
			this.rdb4.Text = "2\"";
			this.rdb4.UseVisualStyleBackColor = true;
			// 
			// rdb3
			// 
			this.rdb3.Location = new System.Drawing.Point(26, 200);
			this.rdb3.Name = "rdb3";
			this.rdb3.Size = new System.Drawing.Size(104, 24);
			this.rdb3.TabIndex = 35;
			this.rdb3.TabStop = true;
			this.rdb3.Text = "1\" 1/4";
			this.rdb3.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(434, 484);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 46);
			this.button1.TabIndex = 39;
			this.button1.Text = "Imprimir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// lblEmpresa
			// 
			this.lblEmpresa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblEmpresa.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmpresa.Location = new System.Drawing.Point(284, 187);
			this.lblEmpresa.Name = "lblEmpresa";
			this.lblEmpresa.Size = new System.Drawing.Size(307, 56);
			this.lblEmpresa.TabIndex = 46;
			this.lblEmpresa.Text = "                           \"Aceros 8 De Julio\"  \r\n  Avenida 8 de julio #1671     " +
			"       Tel.:36193663";
			// 
			// lblNeto
			// 
			this.lblNeto.Location = new System.Drawing.Point(284, 438);
			this.lblNeto.Name = "lblNeto";
			this.lblNeto.Size = new System.Drawing.Size(293, 29);
			this.lblNeto.TabIndex = 45;
			// 
			// lblIva
			// 
			this.lblIva.Location = new System.Drawing.Point(284, 391);
			this.lblIva.Name = "lblIva";
			this.lblIva.Size = new System.Drawing.Size(293, 29);
			this.lblIva.TabIndex = 44;
			// 
			// lblPrecio
			// 
			this.lblPrecio.Location = new System.Drawing.Point(284, 344);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(293, 29);
			this.lblPrecio.TabIndex = 43;
			// 
			// lblMetro
			// 
			this.lblMetro.Location = new System.Drawing.Point(284, 297);
			this.lblMetro.Name = "lblMetro";
			this.lblMetro.Size = new System.Drawing.Size(293, 29);
			this.lblMetro.TabIndex = 42;
			// 
			// lblPeso
			// 
			this.lblPeso.Location = new System.Drawing.Point(284, 257);
			this.lblPeso.Name = "lblPeso";
			this.lblPeso.Size = new System.Drawing.Size(293, 26);
			this.lblPeso.TabIndex = 41;
			// 
			// angulo_1_4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(629, 636);
			this.Controls.Add(this.lblEmpresa);
			this.Controls.Add(this.lblNeto);
			this.Controls.Add(this.lblIva);
			this.Controls.Add(this.lblPrecio);
			this.Controls.Add(this.lblMetro);
			this.Controls.Add(this.lblPeso);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.rdb8);
			this.Controls.Add(this.rdb6);
			this.Controls.Add(this.rdb4);
			this.Controls.Add(this.rdb3);
			this.Controls.Add(this.rdb7);
			this.Controls.Add(this.rdb5);
			this.Controls.Add(this.rdb2);
			this.Controls.Add(this.rdb1);
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
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "angulo_1_4";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ACEROS 8 DE JULIO           Angulo 1/4";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblPeso;
		private System.Windows.Forms.Label lblMetro;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.Label lblIva;
		private System.Windows.Forms.Label lblNeto;
		private System.Windows.Forms.Label lblEmpresa;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton rdb3;
		private System.Windows.Forms.RadioButton rdb4;
		private System.Windows.Forms.RadioButton rdb6;
		private System.Windows.Forms.RadioButton rdb8;
		private System.Windows.Forms.RadioButton rdb7;
		private System.Windows.Forms.RadioButton rdb5;
		private System.Windows.Forms.RadioButton rdb2;
		private System.Windows.Forms.RadioButton rdb1;
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
