using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitosRestobarPorPartes.Modelo;
using TitosRestobarPorPartes.Vistas;

namespace TitosRestobarPorPartes.DAO
{
    internal class StockDAO
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

        internal void Guardar(Stock stock, Producto producto)
        {
            if (stock.IdStock != 0)
            {
                UpDate(stock, producto);
            }
            else
            {
                Crear(stock, producto);
            }

        }

        private void Crear(Stock stock, Producto producto)
        {
            string consulta = "INSERT INTO `stock` (`idStock`, `cantidad`, `idProducto`) VALUES (NULL, '"+stock.Cantidad+"', '"+producto.IdProducto+"');";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void UpDate(Stock stock, Producto producto)
        {
            string consulta = "UPDATE `stock` SET `cantidad` = '"+stock.Cantidad+"' WHERE `stock`.`idStock` = "+stock.IdStock+" AND `stock`.`idProducto` = "+producto.IdProducto+";";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public Stock ObtenerStockporIdProducto(int idProducto)
        {
            Stock stock = new Stock();
            using (MySqlConnection conexion = Conectar())
            {
                string consulta = "SELECT * FROM `stock` WHERE IdProducto = @IdProducto";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdProducto", idProducto);

                using (MySqlDataReader lectura = comando.ExecuteReader())
                {
                    if (lectura.Read())
                    {
                        
                        stock.IdStock = lectura.GetInt32("idStock");
                        stock.Cantidad = lectura.GetInt32("cantidad");

                        return stock;
                    }
                }
            }
            return stock;
        }

    }
}
