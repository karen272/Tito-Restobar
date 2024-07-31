using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitosRestobarPorPartes.Modelo;

namespace TitosRestobarPorPartes.DAO
{
    internal class ItemDAO
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

        public List<Item> listadoDeItems()
        {
            List<Item> lista = new List<Item>();

            string consulta = "SELECT * FROM `pedido_has_producto`";

            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();

            while (lectura.Read())
            {
                Item item = new Item();
                item.IdItem = lectura.GetInt32("idPedidoProducto");
                int idproducto = lectura.GetInt32("Productos_idProductos");
                int idpedido = lectura.GetInt32("Pedidos_idPedidos");

                //Obtenemos el objeto pedido usando el ID
                Pedido pedido = ObtenerPedidoPorId(idpedido);
                item.Pedido = pedido;
                
                //obtenemos el objeto Producto usando el ID
                Producto producto = ObtenerProductoPorId(idproducto);
                item.Producto = producto;

                item.Cantidad = lectura.GetInt32("cantidad");

                lista.Add(item);
                
            }


            return lista;
        }

        private Pedido ObtenerPedidoPorId(int idpedido)
        {
            string consultaPedido = "SELECT * FROM `pedido` WHERE `idPedido` = " + idpedido + ";";

            MySqlCommand comandoPedido = new MySqlCommand(consultaPedido);
            comandoPedido.Connection = Conectar();
            MySqlDataReader lecturaPedido = comandoPedido.ExecuteReader();

            if (lecturaPedido.Read())
            {
                Pedido pedido = new Pedido();
                
                pedido.IdPedido = lecturaPedido.GetInt32("idProductos");

                return pedido;
            }
            else
            {
                return null;
            }
        }



        private Producto ObtenerProductoPorId(int idproducto) 
        {// este metodo puede devolver null un producto? -> Producto? para que devuelva null

            string consultaProducto = "SELECT * FROM `producto` WHERE `idProducto` = " + idproducto + ";";
           
            MySqlCommand comandoProducto = new MySqlCommand(consultaProducto);
            comandoProducto.Connection = Conectar();
            MySqlDataReader lecturaProducto = comandoProducto.ExecuteReader();

            if (lecturaProducto.Read())
            {
                Producto producto = new Producto();
                producto.IdProducto = lecturaProducto.GetInt32("idProductos");
                
                return producto;
            }
            else
            {
                return null;
            }
        }

        private void GuardarItem(Item item)
        {
            if (item.IdItem != 0)
            {
                Ver(item);
            }
            else
            {
                Crear(item);
            }
        }

        public void Crear(Item item)
        {
            string consulta = "INSERT INTO `pedido_has_producto` ( `Pedidos_idPedidos`, `Productos_idProductos`, `cantidad`) VALUES ('" + item.Pedido + "', '" + item.Producto + "', '" + item.Cantidad + "');";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void Ver(Item item)
        {
            string consulta = "SELECT * FROM `pedido_has_producto` ";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
       

    }
}
