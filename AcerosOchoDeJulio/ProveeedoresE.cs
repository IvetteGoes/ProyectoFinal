/*
 * Created by SharpDevelop.
 * User: Owner
 * Date: 6/8/2014
 * Time: 3:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of ProveeedoresE.
	/// </summary>
	public class ProveeedoresE
	{
		public static int Agregar(ProveedorC pProveedor)
		{
			
			int retorno = 0;
			
		    MySqlCommand comando = new MySqlCommand(string.Format("Insert into proveedores (nombre_prove,Direccion,colonia,ciudad,rfc,codigo_postal,telefono,correo_electronico) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
		               										       pProveedor.nombre_prove, pProveedor.direccion, pProveedor.colonia, pProveedor.ciudad, pProveedor.rfc, pProveedor.codigo_postal,
		               										       pProveedor.telefono, pProveedor.correo_electronico), BdComun.ObtenerConexion());
			retorno = comando.ExecuteNonQuery();
			
			return retorno;
		}
		public static List<ProveedorC> Buscar (string pnombre_prove)
		{
			List<ProveedorC> _lista = new List<ProveedorC>();
			
			MySqlCommand _comando = new MySqlCommand(String.Format("SELECT id, nombre_prove, direccion, colonia, ciudad, rfc, codigo_postal, telefono, correo_electronico FROM proveedores where nombre_proveLIKE '%{0}%'", pnombre_prove), BdComun.ObtenerConexion());
			MySqlDataReader _reader = _comando.ExecuteReader();
			
			while (_reader.Read())
			{
				
			    ProveedorC pProveedor = new ProveedorC();
				pProveedor.id = _reader.GetInt32(0);
				pProveedor.nombre_prove= _reader.GetString(1);
				pProveedor.direccion= _reader.GetString(2);
			    pProveedor.colonia= _reader.GetString(3);
				pProveedor.ciudad= _reader.GetString(4);
				pProveedor.rfc= _reader.GetString(5);
				pProveedor.codigo_postal= _reader.GetString(6);
				pProveedor.telefono= _reader.GetString(7);
				pProveedor.correo_electronico= _reader.GetString(8);
				
				_lista.Add(pProveedor);
				
			}
			return _lista;
		}
		
		 public static ProveedorC ObtenerProveedor(int pid_prove)
		 {
		 	ProveedorC pProveedor=new ProveedorC();
			MySqlConnection conexion = BdComun.ObtenerConexion();
			
			MySqlCommand _comando= new MySqlCommand(String.Format("SELECT id, nombre_prove, direccion, colonia, ciudad, rfc,codigo_postal, telefono, correo_electronico FROM proveedores where id='{0}'", pid_prove), conexion);
			MySqlDataReader _reader = _comando.ExecuteReader();
			
			while (_reader.Read())
			{
				
				pProveedor.id = _reader.GetInt32(0);
				pProveedor.nombre_prove= _reader.GetString(1);
				pProveedor.direccion= _reader.GetString(2);
				pProveedor.colonia= _reader.GetString(3);
				pProveedor.ciudad= _reader.GetString(4);
				pProveedor.rfc= _reader.GetString(5);
				pProveedor.codigo_postal= _reader.GetString(6);
				pProveedor.telefono= _reader.GetString(7);
				pProveedor.correo_electronico= _reader.GetString(8);
				
		    }
			conexion.Close();
			return pProveedor;
			
		   
		 }
		 
		  public  static int Editar (ProveedorC pProveedor)
		 {
			
		     int retorno =0;
		
		     MySqlConnection conexion= BdComun.ObtenerConexion();
		     
		     MySqlCommand comando =  new MySqlCommand(string.Format("Update proveedores set nombre_prove='{0}', direccion='{1}',colonia='{2}',ciudad='{3}', rfc='{4}',codigo_postal='{5}', telefono='{6}', correo_electronico='{7}' where id={8}",
		                                             pProveedor.nombre_prove, pProveedor.direccion, pProveedor.colonia, pProveedor.ciudad, pProveedor.rfc, pProveedor.codigo_postal, pProveedor.telefono, pProveedor.correo_electronico, pProveedor.id), conexion);
		                
		     retorno = comando.ExecuteNonQuery();
		     
		     conexion.Close();
			 return retorno;	
	     }
		  
		   public static int Eliminar(int pid_prove)
		{
		   int retorno = 0;
		  
		   MySqlConnection conexion = BdComun.ObtenerConexion();
		   MySqlCommand comando = new MySqlCommand(string.Format("Delete From proveedores where id={0}",pid_prove), conexion);
		  

		   retorno=comando.ExecuteNonQuery();
		
		   conexion.Close();
		   return retorno;
		
		}
	}
}
