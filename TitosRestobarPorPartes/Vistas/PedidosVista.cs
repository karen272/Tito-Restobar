using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TitosRestobarPorPartes.DAO;
using TitosRestobarPorPartes.Modelo;


//Alonso Melina Karen Celes


namespace TitosRestobarPorPartes.Vistas
{
    public partial class PedidosVista : Form
    {
        private int idMesa;

        public PedidosVista(int idMesa)
        {
            InitializeComponent();
            this.idMesa = idMesa;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void actualizarLista()
        {
            ProductosDAO baseDeDatos = new ProductosDAO();
            List<Producto> listaDb = baseDeDatos.listadoDeProductos();

            cmbProductos.Items.Clear();
            for (int i = 0; i < listaDb.Count; i++)
            {
                Producto producto = listaDb[i];
                cmbProductos.Items.Add(producto);

            }
        }

        private void PedidosVista_Load(object sender, EventArgs e)
        {
            lblIdMesaSeleccionada.Text = idMesa.ToString();
            actualizarLista();
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void numUDCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Item item = new Item();

            item.Cantidad = (int)numUDCantidad.Value;
            item.Producto = (Producto)cmbProductos.SelectedItem;


            actualizarLista();

            listPedidos.Items.Add(item);
            Limpiar();

        }

        private void btnCerrarPedido_Click(object sender, EventArgs e)
        {
            int idPedido;
            Mesa mesa = new Mesa();
            mesa.idMesa = idMesa;
            Pedido pedido = new Pedido();
            PedidoDAO baseDeDatos = new PedidoDAO();
            baseDeDatos.ObtenerIdParaCerrarPedido(pedido);

            idPedido = baseDeDatos.ObtenerIdParaCerrarPedido(pedido).IdPedido;

            pedido.IdPedido = idPedido;

            baseDeDatos.CerrarPedido(pedido);

        }

        private void TotalPedido()
        {

        }

        private void Limpiar()
        {
            cmbProductos.Text = "";
        }

        private void btnAbrirPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            Mesa mesa = new Mesa();
            mesa.idMesa = idMesa;

            PedidoDAO baseDeDatos = new PedidoDAO();
            baseDeDatos.Guardar(pedido, mesa);

            lblIdPedido.Text = baseDeDatos.ObtenerIdParaCerrarPedido(pedido).IdPedido.ToString();
        }

        private void btnListarPedido_Click(object sender, EventArgs e)
        {
            ListadoPedidos pedido = new ListadoPedidos();
            pedido.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MesasVista volver = new MesasVista();
            volver.ShowDialog();
        }
    }
}
