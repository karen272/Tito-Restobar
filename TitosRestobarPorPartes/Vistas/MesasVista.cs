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
    public partial class MesasVista : Form
    {
        public MesasVista()
        {
            InitializeComponent();
        }

        private void btnPedidosMesa_Click(object sender, EventArgs e)
        {
            Mesa mesa = (Mesa)listMesa.SelectedItem;

            int idMesaSeleccionada = mesa.idMesa;

            PedidosVista pedido = new PedidosVista(idMesaSeleccionada);
            pedido.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            InicioVistas volver = new InicioVistas();
            volver.ShowDialog();
        }

        private void btnCrearMesa_Click(object sender, EventArgs e)
        {
            Mesa mesa = new Mesa();

            mesa.nombreMesa = txtMesa.Text;

            if (lblIdMesa.Text != "")
            {
                mesa.idMesa = Int32.Parse(lblIdMesa.Text);
            }


            MesasDAO baseDeDatos = new MesasDAO();
            baseDeDatos.Guardar(mesa);

            actualizarLista();
            limpiar();
        }

        private void actualizarLista()
        {
            MesasDAO baseDeDatos = new MesasDAO();
            List<Mesa> listaDb = baseDeDatos.listadoDeMesas();

            listMesa.Items.Clear();
            for (int i = 0; i < listaDb.Count; i++)
            {
                Mesa mesa = listaDb[i];
                listMesa.Items.Add(mesa);
            }
        }

        public void limpiar()
        {
            txtMesa.Text = "";
            lblIdMesa.Text = "";
        }

        private void lblIdMesa_Click(object sender, EventArgs e)
        {

        }

        private void MesasVista_Load(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void btnEliminarMesa_Click(object sender, EventArgs e)
        {
            Mesa mesa = (Mesa)listMesa.SelectedItem;

            MesasDAO baseDeDatos = new MesasDAO();
            baseDeDatos.Elimar(mesa);

            actualizarLista();
        }

        private void btnEditarMesa_Click(object sender, EventArgs e)
        {
            Mesa mesa = (Mesa)listMesa.SelectedItem;
            txtMesa.Text = mesa.nombreMesa;
            lblIdMesa.Text = mesa.idMesa.ToString();

        }
    }
}
