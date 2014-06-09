/*
 * Creado por SharpDevelop.
 * Usuario: Sandra Zuñiga
 * Fecha: 08/06/2014
 * Hora: 12:29 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of Metodos.
	/// </summary>
	public class Clientesmet
	{
		public int id { get; set; }
		public string nombre{ get; set; }
		public string domicilio{ get; set; }
		public string rfc { get; set; }
		public string telefono { get; set; }
		
		public Clientesmet()
		{
		
		}
			public void clientes (int ide,string nom,string dom, string rfce, string tel)
			{
				this.id=ide;
				this.nombre=nom;
				this.domicilio=dom;
				this.rfc=rfce;
				this.telefono=tel;
			}
		
	}
}
