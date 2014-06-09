/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 02/06/2014
 * Time: 12:10 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of BdComun.
	/// </summary>
	public class BdComun
	{
		
		  public static MySqlConnection ObtenerConexion()
       {
           MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=aceros; Uid=root; pwd=erick3;");
           
               conectar.Open();
               return conectar;        
       }
		
	}
}
