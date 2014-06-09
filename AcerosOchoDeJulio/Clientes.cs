/*
 * Creado por SharpDevelop.
 * Usuario: Sandra Zuñiga
 * Fecha: 08/06/2014
 * Hora: 12:29 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of Clientes.
	/// </summary>
	class Clientes
	{
		public static int Agregar (Clientesmet pClientesmet)
		{
			int retorno =0;
			
			MySqlCommand comando= new MySqlCommand(string.Format("Insert into cliente(nombre,domicilio,rfc,telefono) values('{0}','{1}','{2}','{3}')",
			pClientesmet.nombre,pClientesmet.domicilio,pClientesmet.rfc,pClientesmet.telefono), BdComun.ObtenerConexion());
			retorno = comando.ExecuteNonQuery();
			return retorno;
		}
		public static List<Clientesmet> Buscar (string nom)
		{
			List<Clientesmet> _lista = new List<Clientesmet>();
			MySqlCommand _comando = new MySqlCommand(String.Format("SELECT id, nombre, domicilio, rfc, telefono FROM cliente where nombre LIKE '%{0}%'", nom),BdComun.ObtenerConexion());
			MySqlDataReader _reader = _comando.ExecuteReader();
			
			while (_reader.Read())
			{
				Clientesmet pClientes = new Clientesmet();
				pClientes.id = _reader.GetInt32(0);
				pClientes.nombre= _reader.GetString(1);
				pClientes.domicilio= _reader.GetString(2);
				pClientes.rfc= _reader.GetString(3);
				pClientes.telefono= _reader.GetString(4);
				
				_lista.Add(pClientes);
				
			}
			return _lista;
			
		}
		public static Clientesmet ObtenerClientes(int ide)
		{
			Clientesmet pClientes=new Clientesmet();
			MySqlConnection conexion = BdComun.ObtenerConexion();
			
			MySqlCommand _comando= new MySqlCommand(String.Format("SELECT id,nombre,domicilio,rfc,telefono FROM cliente where id='{0}'", ide), 
			BdComun.ObtenerConexion());
			MySqlDataReader _reader = _comando.ExecuteReader();
			
			while (_reader.Read())
			{
				pClientes.id= _reader.GetInt32(0);
				pClientes.nombre= _reader.GetString(1);
				pClientes.domicilio= _reader.GetString(2);
				pClientes.rfc= _reader.GetString(3);
				pClientes.telefono= _reader.GetString(4);
				
			}
			conexion.Close();
			return pClientes;
		}
		public static int Editar(Clientesmet pClientesmet)
		{
			int retorno =0;
		
		MySqlConnection conexion= BdComun.ObtenerConexion();
		
		MySqlCommand comando =  new MySqlCommand(string.Format("Update cliente set nombre='{0}', domicilio='{1}', rfc='{2}',telefono='{3}' where id={4}"
		,pClientesmet.nombre,pClientesmet.domicilio,pClientesmet.rfc,pClientesmet.telefono, pClientesmet.id), conexion);
		retorno = comando.ExecuteNonQuery();
		conexion.Close();
		return retorno;
		}
													
		public static int Eliminar(int ide)
		{
		int retorno = 0;
		MySqlConnection conexion = BdComun.ObtenerConexion();
		MySqlCommand comando = new MySqlCommand(string.Format("Delete From cliente where id={0}",ide), conexion);
		retorno=comando.ExecuteNonQuery();
		conexion.Close();
		return retorno;
		
		}
		
		
		}
	}
	 