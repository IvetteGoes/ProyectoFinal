/*
 * Creado por SharpDevelop.
 * Usuario: Juan
 * Fecha: 04/06/2014
 * Hora: 12:18 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of Usuarios.
	/// </summary>
	public class Usuarios
	{
		public string Id {get;set;}
		public string Nombre {get;set;}
		public string Domicilio {get;set;}
		public string Telefono {get;set;}
		public string CodigoPostal {get;set;}
		public string area_trabajo {get;set;}
		public string Puesto {get;set;}
		
		public Usuarios() { }
		
		public Usuarios(string pId, string pNombre, string pDomicilio, string pTelefono, string pCodigoPostal,
		                string pArea, string pPuesto){
			this.Id = pId;
			this.Nombre = pNombre;
			this.Domicilio = pDomicilio;
			this.Telefono = pTelefono;
			this.CodigoPostal = pCodigoPostal;
			this.area_trabajo = pArea;
			this.Puesto = pPuesto;
		}
	}
}
