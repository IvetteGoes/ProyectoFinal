/*
 * Created by SharpDevelop.
 * User: Owner
 * Date: 6/8/2014
 * Time: 2:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of ProveedorC.
	/// </summary>
	public class ProveedorC
	{
		
			public int id {get;set;}
		    public string nombre_prove {get;set;}
		    public string direccion {get;set;}
		    public string colonia {get;set;}
		    public string ciudad {get;set;}
		    public string rfc {get;set;}
		    public string codigo_postal {get;set;}
		    public string telefono {get;set;}
		    public string correo_electronico {get;set;}
		
		public ProveedorC() {}
		
		public ProveedorC(int pid, string pnombre_prove, string pdireccion, string pcolonia,
		                string pciudad, string prfc, string pcodigo_postal, string ptelefono, string pcorreo_electronico)
		{
			this.id = pid;
			this.nombre_prove = pnombre_prove;
			this.direccion = pdireccion;
			this.colonia = pcolonia;
		    this.ciudad = pciudad;
		    this.rfc = prfc;
		    this.codigo_postal = pcodigo_postal;
		    this.telefono = ptelefono;
		    this.correo_electronico = pcorreo_electronico;
			
		}
	}
}

	
	

