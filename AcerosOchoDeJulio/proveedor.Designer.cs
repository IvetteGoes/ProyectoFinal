/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 09/06/2014
 * Time: 09:33 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AcerosOchoDeJulio
{
	partial class proveedor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(proveedor));
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txttel = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtcodp = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtrfc = new System.Windows.Forms.TextBox();
			this.txtciudad = new System.Windows.Forms.TextBox();
			this.txtcolonia = new System.Windows.Forms.TextBox();
			this.txtcorreo = new System.Windows.Forms.TextBox();
			this.txtdireccion = new System.Windows.Forms.TextBox();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(520, 395);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(91, 32);
			this.btnCancelar.TabIndex = 103;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(364, 357);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(86, 32);
			this.btnEliminar.TabIndex = 102;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(248, 357);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(100, 32);
			this.btnAgregar.TabIndex = 101;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(129, 357);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(102, 33);
			this.btnActualizar.TabIndex = 100;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(16, 357);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(100, 34);
			this.btnBuscar.TabIndex = 99;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// txttel
			// 
			this.txttel.Location = new System.Drawing.Point(107, 249);
			this.txttel.Name = "txttel";
			this.txttel.Size = new System.Drawing.Size(205, 31);
			this.txttel.TabIndex = 98;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 257);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 97;
			this.label8.Text = "Telefono";
			// 
			// txtcodp
			// 
			this.txtcodp.Location = new System.Drawing.Point(397, 212);
			this.txtcodp.Name = "txtcodp";
			this.txtcodp.Size = new System.Drawing.Size(214, 31);
			this.txtcodp.TabIndex = 96;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(328, 220);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 95;
			this.label7.Text = "CP";
			// 
			// txtrfc
			// 
			this.txtrfc.Location = new System.Drawing.Point(107, 212);
			this.txtrfc.Name = "txtrfc";
			this.txtrfc.Size = new System.Drawing.Size(205, 31);
			this.txtrfc.TabIndex = 94;
			// 
			// txtciudad
			// 
			this.txtciudad.Location = new System.Drawing.Point(397, 175);
			this.txtciudad.Name = "txtciudad";
			this.txtciudad.Size = new System.Drawing.Size(214, 31);
			this.txtciudad.TabIndex = 93;
			// 
			// txtcolonia
			// 
			this.txtcolonia.Location = new System.Drawing.Point(107, 175);
			this.txtcolonia.Name = "txtcolonia";
			this.txtcolonia.Size = new System.Drawing.Size(205, 31);
			this.txtcolonia.TabIndex = 92;
			// 
			// txtcorreo
			// 
			this.txtcorreo.Location = new System.Drawing.Point(213, 291);
			this.txtcorreo.Name = "txtcorreo";
			this.txtcorreo.Size = new System.Drawing.Size(398, 31);
			this.txtcorreo.TabIndex = 91;
			// 
			// txtdireccion
			// 
			this.txtdireccion.Location = new System.Drawing.Point(213, 133);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.Size = new System.Drawing.Size(398, 31);
			this.txtdireccion.TabIndex = 90;
			// 
			// txtnombre
			// 
			this.txtnombre.Location = new System.Drawing.Point(213, 96);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(398, 31);
			this.txtnombre.TabIndex = 89;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 220);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 88;
			this.label6.Text = "RFC";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(318, 183);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 87;
			this.label5.Text = "Ciudad";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 183);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 86;
			this.label4.Text = "Colonia";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 85;
			this.label3.Text = "Direccion";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 299);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(171, 23);
			this.label2.TabIndex = 84;
			this.label2.Text = "Correo electronico";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 23);
			this.label1.TabIndex = 83;
			this.label1.Text = "Nombre de Proveedor";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(-38, 443);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(716, 15);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 82;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(16, 27);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(200, 15);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 81;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(421, 27);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(200, 15);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 80;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(238, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(165, 46);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 79;
			this.pictureBox1.TabStop = false;
			// 
			// proveedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(641, 468);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txttel);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtcodp);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtrfc);
			this.Controls.Add(this.txtciudad);
			this.Controls.Add(this.txtcolonia);
			this.Controls.Add(this.txtcorreo);
			this.Controls.Add(this.txtdireccion);
			this.Controls.Add(this.txtnombre);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "proveedor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "proveedor";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.TextBox txtdireccion;
		private System.Windows.Forms.TextBox txtcorreo;
		private System.Windows.Forms.TextBox txtcolonia;
		private System.Windows.Forms.TextBox txtciudad;
		private System.Windows.Forms.TextBox txtrfc;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtcodp;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txttel;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnCancelar;
	}
}
