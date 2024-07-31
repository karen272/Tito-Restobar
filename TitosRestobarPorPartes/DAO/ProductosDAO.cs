using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using TitosRestobarPorPartes.Modelo;
using Microsoft.VisualBasic;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Utilities.Collections;
using System.Net.Http.Json;


//Alonso Melina Karen Celes


namespace TitosRestobarPorPartes.DAO
{
    internal class ProductosDAO
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

        public List<Producto> listadoDeProductos()
        {
            List<Producto> lista = new List<Producto>();

            string consulta = "SELECT * FROM `producto`";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();

            while (lectura.Read())
            {
                Producto producto = new Producto();
 
                producto.IdProducto = lectura.GetInt32("idproducto");
                producto.Nombre = lectura.GetString("nombre");
                producto.Descripcion = lectura.GetString("descripcion");
                producto.Precio = lectura.GetDecimal("precio");
                producto.Costo = lectura.GetDecimal("costo");
                

                lista.Add(producto);
            }

            comando.Connection.Close();

            return lista;
        }

        internal void Guardar(Producto producto)
        {
            if (producto.IdProducto != 0)
            {
                UpDate(producto);
            }
            else
            {
                Crear(producto);
            }

        }

        private void Crear(Producto producto)
        {
            string consulta = "INSERT INTO `producto` ( `nombre`, `descripcion`, `precio`, `costo`) VALUES ('" + producto.Nombre + "', '" + producto.Descripcion + "', '" + producto.Precio + "', '" + producto.Costo + "');";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void UpDate(Producto producto)
        {
            string consulta = "UPDATE `producto` SET `nombre` = '"+producto.Nombre+"', `descripcion` = '"+ producto.Descripcion +"', `precio` = '"+producto.Precio+"', `costo` = '"+producto.Costo+"' WHERE `producto`.`idProducto` = "+producto.IdProducto+";";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        internal void Elimar(Producto producto)
        {
            string consulta = "DELETE FROM `producto` WHERE `producto`.`idProducto` = " + producto.IdProducto + ";";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void PasarPrecio(Producto producto)
        {
            DateTime fechaHora = DateTime.Now;
            string fechaHoraFormateada = fechaHora.ToString("yyyy-MM-dd HH:mm:ss");

            string consulta = "INSERT INTO `precio` (`idPrecio`, `precioProducto`, `fechaYHora`, `idProducto`) VALUES (NULL, ?, ?, ?)";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();

            // Parámetros para el precio, la fecha y hora, y el id del producto
            comando.Parameters.AddWithValue("@Precio", producto.Precio);
            comando.Parameters.AddWithValue("@FechaHora", fechaHoraFormateada);
            comando.Parameters.AddWithValue("@IdProducto", producto.IdProducto);

            // Ejecutar la consulta
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }


    }
}
