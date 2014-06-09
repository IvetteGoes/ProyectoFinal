/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 09/06/2014
 * Time: 10:44 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AcerosOchoDeJulio
{
	partial class BuscarCliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarCliente));
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btCerrar = new System.Windows.Forms.Button();
			this.btBuscar = new System.Windows.Forms.Button();
			this.btAceptar = new System.Windows.Forms.Button();
			this.dgvBscar = new System.Windows.Forms.DataGridView();
			this.lbNombre = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvBscar)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(70, 47);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(152, 31);
			this.txtNombre.TabIndex = 11;
			// 
			// btCerrar
			// 
			this.btCerrar.Location = new System.Drawing.Point(299, 227);
			this.btCerrar.Name = "btCerrar";
			this.btCerrar.Size = new System.Drawing.Size(86, 48);
			this.btCerrar.TabIndex = 10;
			this.btCerrar.Text = "Cerrar";
			this.btCerrar.UseVisualStyleBackColor = true;
			this.btCerrar.Click += new System.EventHandler(this.BtCerrarClick);
			// 
			// btBuscar
			// 
			this.btBuscar.Location = new System.Drawing.Point(84, 227);
			this.btBuscar.Name = "btBuscar";
			this.btBuscar.Size = new System.Drawing.Size(86, 48);
			this.btBuscar.TabIndex = 9;
			this.btBuscar.Text = "Buscar";
			this.btBuscar.UseVisualStyleBackColor = true;
			this.btBuscar.Click += new System.EventHandler(this.BtBuscarClick);
			// 
			// btAceptar
			// 
			this.btAceptar.Location = new System.Drawing.Point(194, 227);
			this.btAceptar.Name = "btAceptar";
			this.btAceptar.Size = new System.Drawing.Size(86, 48);
			this.btAceptar.TabIndex = 8;
			this.btAceptar.Text = "Aceptarr";
			this.btAceptar.UseVisualStyleBackColor = true;
			this.btAceptar.Click += new System.EventHandler(this.BtAceptarClick);
			// 
			// dgvBscar
			// 
			this.dgvBscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBscar.Location = new System.Drawing.Point(70, 83);
			this.dgvBscar.Name = "dgvBscar";
			this.dgvBscar.Size = new System.Drawing.Size(511, 120);
			this.dgvBscar.TabIndex = 7;
			// 
			// lbNombre
			// 
			this.lbNombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lbNombre.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNombre.Location = new System.Drawing.Point(70, 20);
			this.lbNombre.Name = "lbNombre";
			this.lbNombre.Size = new System.Drawing.Size(100, 23);
			this.lbNombre.TabIndex = 6;
			this.lbNombre.Text = "Nombre";
			// 
			// BuscarCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(651, 294);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.btCerrar);
			this.Controls.Add(this.btBuscar);
			this.Controls.Add(this.btAceptar);
			this.Controls.Add(this.dgvBscar);
			this.Controls.Add(this.lbNombre);
			this.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "BuscarCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BuscarCliente";
			((System.ComponentModel.ISupportInitialize)(this.dgvBscar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lbNombre;
		private System.Windows.Forms.DataGridView dgvBscar;
		private System.Windows.Forms.Button btAceptar;
		private System.Windows.Forms.Button btBuscar;
		private System.Windows.Forms.Button btCerrar;
		private System.Windows.Forms.TextBox txtNombre;
	}
}
