/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 09/06/2014
 * Time: 10:37 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AcerosOchoDeJulio
{
	partial class CHerramientas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHerramientas));
			this.nombre = new System.Windows.Forms.Label();
			this.btncancelar = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txttelefono = new System.Windows.Forms.TextBox();
			this.telefono = new System.Windows.Forms.Label();
			this.txtrfc = new System.Windows.Forms.TextBox();
			this.rfc = new System.Windows.Forms.Label();
			this.txtdomicilio = new System.Windows.Forms.TextBox();
			this.domicilio = new System.Windows.Forms.Label();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// nombre
			// 
			this.nombre.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nombre.Location = new System.Drawing.Point(36, 157);
			this.nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.nombre.Name = "nombre";
			this.nombre.Size = new System.Drawing.Size(132, 41);
			this.nombre.TabIndex = 69;
			this.nombre.Text = "Nombre";
			// 
			// btncancelar
			// 
			this.btncancelar.Location = new System.Drawing.Point(415, 462);
			this.btncancelar.Margin = new System.Windows.Forms.Padding(4);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.Size = new System.Drawing.Size(114, 44);
			this.btncancelar.TabIndex = 68;
			this.btncancelar.Text = "Cancelar";
			this.btncancelar.UseVisualStyleBackColor = true;
			this.btncancelar.Click += new System.EventHandler(this.BtncancelarClick);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(415, 366);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(114, 44);
			this.button4.TabIndex = 67;
			this.button4.Text = "Eliminar";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(415, 280);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(114, 44);
			this.button3.TabIndex = 66;
			this.button3.Text = "Editar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(415, 195);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(114, 44);
			this.button2.TabIndex = 65;
			this.button2.Text = "Agregar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(415, 99);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 44);
			this.button1.TabIndex = 64;
			this.button1.Text = "Buscar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(13, 35);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(177, 21);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 63;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(384, 35);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(176, 21);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 62;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(198, 13);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(178, 54);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 61;
			this.pictureBox1.TabStop = false;
			// 
			// txttelefono
			// 
			this.txttelefono.Location = new System.Drawing.Point(38, 420);
			this.txttelefono.Margin = new System.Windows.Forms.Padding(4);
			this.txttelefono.Name = "txttelefono";
			this.txttelefono.Size = new System.Drawing.Size(254, 31);
			this.txttelefono.TabIndex = 60;
			// 
			// telefono
			// 
			this.telefono.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.telefono.Location = new System.Drawing.Point(36, 377);
			this.telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.telefono.Name = "telefono";
			this.telefono.Size = new System.Drawing.Size(162, 39);
			this.telefono.TabIndex = 59;
			this.telefono.Text = "Telefono";
			// 
			// txtrfc
			// 
			this.txtrfc.Location = new System.Drawing.Point(40, 335);
			this.txtrfc.Margin = new System.Windows.Forms.Padding(4);
			this.txtrfc.Name = "txtrfc";
			this.txtrfc.Size = new System.Drawing.Size(252, 31);
			this.txtrfc.TabIndex = 58;
			// 
			// rfc
			// 
			this.rfc.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rfc.Location = new System.Drawing.Point(44, 301);
			this.rfc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.rfc.Name = "rfc";
			this.rfc.Size = new System.Drawing.Size(154, 39);
			this.rfc.TabIndex = 57;
			this.rfc.Text = "R.F.C.";
			// 
			// txtdomicilio
			// 
			this.txtdomicilio.Location = new System.Drawing.Point(38, 267);
			this.txtdomicilio.Margin = new System.Windows.Forms.Padding(4);
			this.txtdomicilio.Name = "txtdomicilio";
			this.txtdomicilio.Size = new System.Drawing.Size(252, 31);
			this.txtdomicilio.TabIndex = 56;
			// 
			// domicilio
			// 
			this.domicilio.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.domicilio.Location = new System.Drawing.Point(38, 232);
			this.domicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.domicilio.Name = "domicilio";
			this.domicilio.Size = new System.Drawing.Size(132, 41);
			this.domicilio.TabIndex = 55;
			this.domicilio.Text = "Domicilio";
			// 
			// txtnombre
			// 
			this.txtnombre.Location = new System.Drawing.Point(36, 202);
			this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(252, 31);
			this.txtnombre.TabIndex = 54;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(-11, 536);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(617, 21);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 70;
			this.pictureBox4.TabStop = false;
			// 
			// CHerramientas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(573, 564);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.nombre);
			this.Controls.Add(this.btncancelar);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txttelefono);
			this.Controls.Add(this.telefono);
			this.Controls.Add(this.txtrfc);
			this.Controls.Add(this.rfc);
			this.Controls.Add(this.txtdomicilio);
			this.Controls.Add(this.domicilio);
			this.Controls.Add(this.txtnombre);
			this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "CHerramientas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CHerramientas";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label domicilio;
		private System.Windows.Forms.TextBox txtdomicilio;
		private System.Windows.Forms.Label rfc;
		private System.Windows.Forms.TextBox txtrfc;
		private System.Windows.Forms.Label telefono;
		private System.Windows.Forms.TextBox txttelefono;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button btncancelar;
		private System.Windows.Forms.Label nombre;
	}
}
