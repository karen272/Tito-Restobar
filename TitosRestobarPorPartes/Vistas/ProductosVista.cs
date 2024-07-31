using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TitosRestobarPorPartes.DAO;
using TitosRestobarPorPartes.Modelo;
using TitosRestobarPorPartes.Vistas;


//Alonso Melina Karen Celes


namespace TitosRestobarPorPartes
{
    public partial class ProductosVista : Form
    {
        public ProductosVista()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = txtNombreProducto.Text;
            producto.Descripcion = txtDescripcionProducto.Text;
            producto.Costo = decimal.Parse(txtCostoProducto.Text);
            producto.Precio = decimal.Parse(txtPrecioProducto.Text);


            // Intentar convertir lblIdProducto.Text a un número
            if (lblIdProducto.Text != "")
            {
                producto.IdProducto = Int32.Parse(lblIdProducto.Text);
            }


            ProductosDAO baseDeDatos = new ProductosDAO();
            baseDeDatos.Guardar(producto);
            baseDeDatos.PasarPrecio(producto);
            actualizarLista();
            LimpiarList();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        /**
         * 
         * 
         */
        private void actualizarLista()
        {
            ProductosDAO baseDeDatos = new ProductosDAO();
            List<Producto> listaDb = baseDeDatos.listadoDeProductos();

            listProducto.Items.Clear();
            for (int i = 0; i < listaDb.Count; i++)
            {
                Producto producto = listaDb[i];
                listProducto.Items.Add(producto);
            }
        }

        private void LimpiarList()
        {
            txtCostoProducto.Text = "";
            txtDescripcionProducto.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioProducto.Text = "";
            lblIdProducto.Text = "";
        }

        private void ProductosVista_Load(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void listProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //controlar el Stock
        private void button5_Click(object sender, EventArgs e)
        {
            Producto producto = (Producto)listProducto.SelectedItem;
            int idProducto = producto.IdProducto;
            string nombreProducto = producto.Nombre;

            StockVista stock = new StockVista(idProducto, nombreProducto);
            stock.Show();

        }

        //Editar el producto
        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = (Producto)listProducto.SelectedItem;
            txtNombreProducto.Text = producto.Nombre;
            txtDescripcionProducto.Text = producto.Descripcion;
            txtPrecioProducto.Text = producto.Precio.ToString();
            txtCostoProducto.Text = producto.Costo.ToString();
            lblIdProducto.Text = producto.IdProducto.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Producto producto = (Producto)listProducto.SelectedItem;

            ProductosDAO baseDeDatos = new ProductosDAO();
            baseDeDatos.Elimar(producto);

            actualizarLista();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InicioVistas volver = new InicioVistas();
            volver.ShowDialog();
        }
    }
}