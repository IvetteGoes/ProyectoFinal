/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 09/06/2014
 * Time: 08:31 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AcerosOchoDeJulio
{
	partial class agregar_Usuario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregar_Usuario));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.BtnRegresar = new System.Windows.Forms.Button();
			this.BtnEliminar = new System.Windows.Forms.Button();
			this.BtnBuscar = new System.Windows.Forms.Button();
			this.BtnActualizar = new System.Windows.Forms.Button();
			this.BtnGuardar = new System.Windows.Forms.Button();
			this.txtPuesto = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtArea = new System.Windows.Forms.TextBox();
			this.txtCodigoPostal = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(440, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(136, 34);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 38;
			this.pictureBox1.TabStop = false;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(49, 174);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 23);
			this.label7.TabIndex = 37;
			this.label7.Text = "Area";
			// 
			// BtnRegresar
			// 
			this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.BtnRegresar.Location = new System.Drawing.Point(452, 217);
			this.BtnRegresar.Name = "BtnRegresar";
			this.BtnRegresar.Size = new System.Drawing.Size(91, 32);
			this.BtnRegresar.TabIndex = 36;
			this.BtnRegresar.Text = "Regresar";
			this.BtnRegresar.UseVisualStyleBackColor = true;
			this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// BtnEliminar
			// 
			this.BtnEliminar.Location = new System.Drawing.Point(350, 217);
			this.BtnEliminar.Name = "BtnEliminar";
			this.BtnEliminar.Size = new System.Drawing.Size(91, 34);
			this.BtnEliminar.TabIndex = 35;
			this.BtnEliminar.Text = "Eliminar";
			this.BtnEliminar.UseVisualStyleBackColor = true;
			this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// BtnBuscar
			// 
			this.BtnBuscar.Location = new System.Drawing.Point(146, 217);
			this.BtnBuscar.Name = "BtnBuscar";
			this.BtnBuscar.Size = new System.Drawing.Size(91, 34);
			this.BtnBuscar.TabIndex = 34;
			this.BtnBuscar.Text = "Buscar";
			this.BtnBuscar.UseVisualStyleBackColor = true;
			this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// BtnActualizar
			// 
			this.BtnActualizar.Location = new System.Drawing.Point(248, 217);
			this.BtnActualizar.Name = "BtnActualizar";
			this.BtnActualizar.Size = new System.Drawing.Size(91, 34);
			this.BtnActualizar.TabIndex = 33;
			this.BtnActualizar.Text = "Actualizar";
			this.BtnActualizar.UseVisualStyleBackColor = true;
			this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// BtnGuardar
			// 
			this.BtnGuardar.Location = new System.Drawing.Point(47, 217);
			this.BtnGuardar.Name = "BtnGuardar";
			this.BtnGuardar.Size = new System.Drawing.Size(91, 34);
			this.BtnGuardar.TabIndex = 32;
			this.BtnGuardar.Text = "Guardar";
			this.BtnGuardar.UseVisualStyleBackColor = true;
			this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// txtPuesto
			// 
			this.txtPuesto.Location = new System.Drawing.Point(374, 171);
			this.txtPuesto.Name = "txtPuesto";
			this.txtPuesto.Size = new System.Drawing.Size(156, 31);
			this.txtPuesto.TabIndex = 31;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(312, 174);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 30;
			this.label6.Text = "Puesto";
			// 
			// txtArea
			// 
			this.txtArea.Location = new System.Drawing.Point(131, 171);
			this.txtArea.Name = "txtArea";
			this.txtArea.Size = new System.Drawing.Size(156, 31);
			this.txtArea.TabIndex = 29;
			// 
			// txtCodigoPostal
			// 
			this.txtCodigoPostal.Location = new System.Drawing.Point(374, 129);
			this.txtCodigoPostal.Name = "txtCodigoPostal";
			this.txtCodigoPostal.Size = new System.Drawing.Size(156, 31);
			this.txtCodigoPostal.TabIndex = 28;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(131, 129);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(156, 31);
			this.txtTelefono.TabIndex = 27;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(312, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 26;
			this.label4.Text = "C.P.";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(49, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 25;
			this.label3.Text = "Telefono";
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.Location = new System.Drawing.Point(131, 92);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(399, 31);
			this.txtDomicilio.TabIndex = 24;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(49, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 23;
			this.label2.Text = "Domicilio";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(131, 55);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(399, 31);
			this.txtNombre.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(49, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 21;
			this.label1.Text = "Nombre";
			// 
			// agregar_Usuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(578, 273);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.BtnRegresar);
			this.Controls.Add(this.BtnEliminar);
			this.Controls.Add(this.BtnBuscar);
			this.Controls.Add(this.BtnActualizar);
			this.Controls.Add(this.BtnGuardar);
			this.Controls.Add(this.txtPuesto);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtArea);
			this.Controls.Add(this.txtCodigoPostal);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDomicilio);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "agregar_Usuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "agregar_Usuario";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtCodigoPostal;
		private System.Windows.Forms.TextBox txtArea;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPuesto;
		private System.Windows.Forms.Button BtnGuardar;
		private System.Windows.Forms.Button BtnActualizar;
		private System.Windows.Forms.Button BtnBuscar;
		private System.Windows.Forms.Button BtnEliminar;
		private System.Windows.Forms.Button BtnRegresar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
