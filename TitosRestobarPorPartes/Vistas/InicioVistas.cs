using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitosRestobarPorPartes.Vistas
{
    public partial class InicioVistas : Form
    {
        public InicioVistas()
        {
            InitializeComponent();
        }

        private void btnIrAProductos_Click(object sender, EventArgs e)
        {
            ProductosVista productos = new ProductosVista();
            productos.ShowDialog();
        }

        private void btnIrAMesas_Click(object sender, EventArgs e)
        {
            MesasVista mesas = new MesasVista();
            mesas.ShowDialog();
        }
    }
}
