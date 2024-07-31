using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitosRestobarPorPartes.Modelo;

namespace TitosRestobarPorPartes.DAO
{
    internal class MesasDAO
    {
        public MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "";
            string baseDeDatos = "mydb";

            string cadenaConexion = "DataBase=" + baseDeDatos + "; Data Source= " + servidor + "; user Id= " + usuario + "; Password = " + password + "";
            MySqlConnection conexionDb = new MySqlConnection(cadenaConexion);
            conexionDb.Open();

            return conexionDb;
        }

        public List<Mesa> listadoDeMesas()
        {
            List<Mesa> lista = new List<Mesa>();

            string consulta = "SELECT * FROM `mesa`";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();

            while (lectura.Read())
            {
                Mesa mesa = new Mesa();

                mesa.nombreMesa = lectura.GetString("nombre");
                mesa.idMesa = lectura.GetInt32("idMesa");
        


                lista.Add(mesa);
            }

            comando.Connection.Close();

            return lista;
        }

        internal void Guardar(Mesa mesa)
        {
            if (mesa.idMesa != 0)
            {
                UpDate(mesa);
            }
            else
            {
                Crear(mesa);
            }
        }

        private void Crear(Mesa mesa)
        {
            string consulta = "INSERT INTO `mesa` (`nombre`) VALUES ('"+ mesa.nombreMesa +"');" ;
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();    
            comando.Connection.Close();
        }

        public void UpDate(Mesa mesa)
        {
            string consulta = "UPDATE `mesa` SET `nombre` = '"+ mesa.nombreMesa +"' WHERE `mesa`.`idMesa` = "+ mesa.idMesa +";";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        internal void Elimar(Mesa mesa)
        {
            string consulta = "DELETE FROM mesa WHERE `mesa`.`idMesa` = "+ mesa.idMesa +";";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
    }
}
