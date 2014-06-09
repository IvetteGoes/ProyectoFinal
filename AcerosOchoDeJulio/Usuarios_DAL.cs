/*
 * Creado por SharpDevelop.
 * Usuario: Juan
 * Fecha: 04/06/2014
 * Hora: 12:25 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of Usuarios_DAL.
	/// </summary>
	public class Usuarios_DAL
	{
		
		public static int Agregar(Usuarios pUsuarios){
			
			int retorno = 0;
			
			MySqlCommand comando = new MySqlCommand(string.Format("insert into usuario(nombre,domicilio,telefono,codigoPostal,"+
			                                                      "area_T,puesto)values('{0}','{1}','{2}','{3}','{4}','{5}')",
			                                                      pUsuarios.Nombre,pUsuarios.Domicilio,pUsuarios.Telefono,pUsuarios.CodigoPostal,
			                                                      pUsuarios.area_trabajo,pUsuarios.Puesto),BdComun.ObtenerConexion());  
			
			retorno = comando.ExecuteNonQuery();
			return retorno;
			
		}
		public static List<Usuarios>Buscar(string pNombre){ 
			
			List<Usuarios> lista = new List<Usuarios>();     //Usamos un tipo lista para listar los elementos agregados a la base de datos
			
			MySqlCommand comando = new MySqlCommand(String.Format("SELECT id, nombre, domicilio, telefono, codigoPostal, area_T,puesto" +
"			                                                      FROM usuario where nombre LIKE '%{0}%'",pNombre),BdComun.ObtenerConexion());//insertamos la consulta 
			
			MySqlDataReader reader =  comando.ExecuteReader();
			
			while(reader.Read()){          // lee los datos de ingresados 
				
				Usuarios pUsuario = new Usuarios();
				pUsuario.Id = reader.GetString(0);    
				pUsuario.Nombre = reader.GetString(1);
				pUsuario.Domicilio = reader.GetString(2);
				pUsuario.Telefono = reader.GetString(3);
				pUsuario.CodigoPostal = reader.GetString(4);
				pUsuario.area_trabajo = reader.GetString(5);
				pUsuario.Puesto = reader.GetString(6);
				
				lista.Add(pUsuario); //Agrega la lista.
	
			}
			return lista;
		}
		
		public static Usuarios obtener_Cliente(string pId){
			
			Usuarios pUsuario = new Usuarios();
			
			MySqlConnection conexion = BdComun.ObtenerConexion();
			
			MySqlCommand comando = new MySqlCommand(String.Format("SELECT id,nombre,domicilio,telefono,codigoPostal,area_T,puesto" +
"			                                                      FROM usuario where usuario.id ={0}",pId),conexion);
			
			MySqlDataReader reader = comando.ExecuteReader();
			
			while(reader.Read()){
				
				pUsuario.Id = reader.GetString(0);   
				pUsuario.Nombre = reader.GetString(1);
				pUsuario.Domicilio = reader.GetString(2);
				pUsuario.Telefono = reader.GetString(3);
				pUsuario.CodigoPostal = reader.GetString(4);
				pUsuario.area_trabajo = reader.GetString(5);
				pUsuario.Puesto = reader.GetString(6);
				
				
				
			}
			
			conexion.Close(); // se cierra la conexion
			return pUsuario;
			
			}
		
		
		public static int Actualizar(Usuarios pUsuario){
			
			int retorno = 0;
			MySqlConnection conexion = BdComun.ObtenerConexion();
			MySqlCommand comado = new MySqlCommand(string.Format("update usuario set nombre ='{0}',domicilio ='{1}',telefono = '{2}',codigoPostal = '{3}',area_T = '{4}', puesto = '{5}' where usuario.id = {6}",
			                                                     pUsuario.Nombre,pUsuario.Domicilio,pUsuario.Telefono,pUsuario.CodigoPostal,
			                                                     pUsuario.area_trabajo,pUsuario.Puesto,pUsuario.Id),conexion);
			
			retorno =comado.ExecuteNonQuery();
			conexion.Close();    //Se cierra la conexion
			
			
			
			return retorno;
		}
		
		public static int Eliminar(string pId){
			int retorno = 0;
			
			MySqlConnection conexion = BdComun.ObtenerConexion();
			MySqlCommand comando = new MySqlCommand(string.Format("delete from usuario where usuario.id = {0}", pId),conexion);
			retorno= comando.ExecuteNonQuery();
			conexion.Close();
			
			return retorno;
			
		
		}
		
		public Usuarios_DAL()
		{
		}
	}
}
