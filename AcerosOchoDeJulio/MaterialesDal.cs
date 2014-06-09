/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 02/06/2014
 * Time: 11:54 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;


namespace AcerosOchoDeJulio
{
	/// <summary>
	/// Description of MaterialesDal.
	/// </summary>
	class MaterialesDal
	{
		public static int Agregar(Material pMaterial)
       {

       int retorno = 0;

           MySqlCommand comando=new MySqlCommand(string.Format("Insert into material (nombre, medida, peso) values ('{0}','{1}','{2}')",
           pMaterial.Nombre, pMaterial.Medida, pMaterial.Peso),  BdComun.ObtenerConexion()); 
           retorno = comando.ExecuteNonQuery();
           return  retorno;
       }
		
		public static List<Material> Buscar(string pNombre)
       {
           List<Material> _lista = new List<Material>();
           
               MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Id, Nombre, Medida, Peso FROM material  where nombre LIKE '%{0}%' ", 
               pNombre), BdComun.ObtenerConexion());
               MySqlDataReader _reader = _comando.ExecuteReader();
               
               while (_reader.Read())
               {
                   Material pMaterial = new Material();
                   pMaterial.Id = _reader.GetInt32(0);
                   pMaterial.Nombre = _reader.GetString(1);
                   pMaterial.Medida = _reader.GetString(2);
                   pMaterial.Peso = _reader.GetString(3);
                  
                   

                   _lista.Add(pMaterial);
               }
           
           return _lista;
       }
		
		public static Material ObtenerMaterial(int pId)
       {
           Material pMaterial = new Material();
           MySqlConnection conexion = BdComun.ObtenerConexion();

           MySqlCommand _comando = new MySqlCommand(String.Format("SELECT id, nombre, medida, peso FROM material  where id ='{0}' ", pId), 
                                                    BdComun.ObtenerConexion());
           MySqlDataReader _reader = _comando.ExecuteReader();
               while (_reader.Read())
               {
                   
                   pMaterial.Id=_reader.GetInt32(0);
                   pMaterial.Nombre=_reader.GetString(1);
                   pMaterial.Medida=_reader.GetString(2);
                   pMaterial.Peso=_reader.GetString(3);
                   
                   
               }

           conexion.Close();
           return pMaterial;
           
        }
		public static int Editar(Material pMaterial)
        {
            int retorno = 0;
            MySqlConnection conexion = BdComun.ObtenerConexion();
            
                MySqlCommand comando = new MySqlCommand(string.Format("Update material set nombre='{0}', medida='{1}', peso='{2}' where id={3}",
                    pMaterial.Nombre, pMaterial.Medida, pMaterial.Peso, pMaterial.Id), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            
            return retorno;


        }
		
		public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = BdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From material where id={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

		}
	}
}
