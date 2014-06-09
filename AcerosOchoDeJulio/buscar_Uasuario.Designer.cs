/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 09/06/2014
 * Time: 08:50 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AcerosOchoDeJulio
{
	partial class buscar_Uasuario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscar_Uasuario));
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.dataGrid_Usurios = new System.Windows.Forms.DataGridView();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Usurios)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(341, 154);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(101, 34);
			this.btnRegresar.TabIndex = 13;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(340, 114);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(101, 34);
			this.btnAceptar.TabIndex = 12;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(341, 73);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(101, 34);
			this.btnBuscar.TabIndex = 11;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// dataGrid_Usurios
			// 
			this.dataGrid_Usurios.BackgroundColor = System.Drawing.Color.GhostWhite;
			this.dataGrid_Usurios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid_Usurios.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGrid_Usurios.Location = new System.Drawing.Point(13, 71);
			this.dataGrid_Usurios.Name = "dataGrid_Usurios";
			this.dataGrid_Usurios.Size = new System.Drawing.Size(315, 189);
			this.dataGrid_Usurios.TabIndex = 10;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(81, 21);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(195, 31);
			this.txtNombre.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(1, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Nombre";
			// 
			// buscar_Uasuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(454, 272);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.dataGrid_Usurios);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "buscar_Uasuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "buscar_Uasuario";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Usurios)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.DataGridView dataGrid_Usurios;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnRegresar;
	}
}
