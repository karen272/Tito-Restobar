using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitosRestobarPorPartes.Modelo;


//Alonso Melina Karen Celes


namespace TitosRestobarPorPartes.DAO
{
    internal class PedidoDAO
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

        public List<Pedido> listadoDePedidos()
        {
            List<Pedido> lista = new List<Pedido>();


            string consulta = "SELECT * FROM `pedido`";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();

            while (lectura.Read())
            {
                Pedido pedido = new Pedido();
                pedido.IdPedido = lectura.GetInt32("idpedido");
                //pedido.FechayHoraApertura = lectura.GetDateTime("fechaYHoraApertura");
                //pedido.FechayHoraCierre = lectura.GetDateTime("fechaYHoraCierre");

                lista.Add(pedido);
            }

            comando.Connection.Close();

            return lista;
        }

        internal void Guardar(Pedido pedido, Mesa mesa)
        {
            if (pedido.IdPedido != 0)
            {
                CerrarPedido(pedido);
            }
            else
            {
                InsertarApertura(pedido, mesa);
            }
        }

        private void InsertarApertura(Pedido pedido, Mesa mesa)
        {
            DateTime fechaHora = DateTime.Now;
            string fechaHoraFormateada = fechaHora.ToString("yyyy-MM-dd HH:mm:ss");

            string consulta = "INSERT INTO `pedido` (`idPedido`, `fechaYHoraApertura`, `fechaYHoraCierre`, `idMesa`) VALUES (NULL, @FechaHora, NULL, @IdMesa);";

            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();

            comando.Parameters.AddWithValue("@FechaHora", fechaHoraFormateada);
            comando.Parameters.AddWithValue("@IdMesa", mesa.idMesa);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
        
        public void CerrarPedido(Pedido pedido)
        {
            DateTime fechaHora = DateTime.Now;
            string fechaHoraFormateada = fechaHora.ToString("yyyy-MM-dd HH:mm:ss");

            string consulta = "UPDATE `pedido` SET `fechaYHoraCierre` = @FechaHora WHERE `pedido`.`idPedido` = @IdPedido;";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();

            comando.Parameters.AddWithValue("@FechaHora", fechaHoraFormateada);
            comando.Parameters.AddWithValue("@IdPedido", pedido.IdPedido);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Pedido ObtenerIdParaCerrarPedido(Pedido pedido)
        {
            using (MySqlConnection conexion = Conectar())
            {
                string consulta = "SELECT * FROM `pedido` WHERE `pedido`.`fechaYHoraCierre` IS NULL;";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                using (MySqlDataReader lectura = comando.ExecuteReader())
                {
                    if (lectura.Read())
                    {
                        pedido.IdPedido = lectura.GetInt32("idPedido");
                        return pedido;
                    }
                }
            }
            return pedido;
        }
        /* public Pedido ObtenerIdParaCerrarPedido(Pedido pedido)
         {
             using (MySqlConnection conexion = Conectar())
             {
                 string consulta = "SELECT * FROM `pedido` WHERE `pedido`.`fechaYHoraCierre` = 'NULL';";
                 MySqlCommand comando = new MySqlCommand(consulta, conexion);

                 using (MySqlDataReader lectura = comando.ExecuteReader())
                 {
                     if (lectura.Read())
                     {

                         pedido.IdPedido = lectura.GetInt32("idPedido");

                         return pedido;
                     }
                 }
             }
             return pedido;
         }
        */

    }
}

