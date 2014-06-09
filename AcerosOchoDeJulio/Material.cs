/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 02/06/2014
 * Time: 11:46 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of Material.
	/// </summary>
	public class Material
	{
	   public int Id { get; set; }
       public string Nombre { get; set; }
       public string Medida { get; set; }
       public string Peso { get; set; }
      
       
		public Material()
		{
			
		}
		public Material(int pId, string pNombre, string pMedida, string pPeso)

       {
    	   this.Id = pId;
           this.Nombre = pNombre;
           this.Medida = pMedida;
           this.Peso = pPeso;  
		   		   
       }
	}
}
