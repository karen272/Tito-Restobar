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

namespace TitosRestobarPorPartes.Vistas
{
    public partial class StockVista : Form
    {
        public int idProducto;
        private string nombreProducto;
        public StockVista(int idProducto, string nombreProducto)
        {
            InitializeComponent();
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;

        }



        private void IdProductoStock_Click(object sender, EventArgs e)
        {

        }

        private void StockVista_Load(object sender, EventArgs e)
        {


            lblIdProductoStock.Text = idProducto.ToString();
            lblNombreProducto.Text = nombreProducto;

            StockDAO baseDeDatos = new StockDAO();
            baseDeDatos.ObtenerStockporIdProducto(idProducto);

            if (baseDeDatos.ObtenerStockporIdProducto(idProducto).IdStock.ToString() != null)
            {
                lblIdStock.Text = baseDeDatos.ObtenerStockporIdProducto(idProducto).IdStock.ToString();
                numStock.Value = baseDeDatos.ObtenerStockporIdProducto(idProducto).Cantidad;
            }
            else
            {
                MessageBox.Show("Producto no encontrado");
            }

        }



        //Actualizar Stock
        private void button1_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            Producto producto = new Producto();
            stock.Cantidad = (int)numStock.Value;
            producto.IdProducto = idProducto;

            if (lblIdStock.Text != "")
            {
                stock.IdStock = Int32.Parse(lblIdStock.Text);
            }

            StockDAO baseDeDatos = new StockDAO();
            baseDeDatos.Guardar(stock, producto);
          //  actualizarLista();
            //            LimpiarList();
        }
    }
}
