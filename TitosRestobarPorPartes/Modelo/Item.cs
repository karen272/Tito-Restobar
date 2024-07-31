using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Alonso Melina Karen Celes


namespace TitosRestobarPorPartes.Modelo
{
    internal class Item
    {
        private int idItem;
        private Producto producto;
        private int cantidad;
        private Pedido pedido;
        private decimal totalIndividual;
        

        // Constructores
        public Item()
        {

        }

        public Item (int idItem, Producto producto, int cantidad, decimal totalIndividual, Pedido pedido)
        {
            this.idItem = idItem;
            this.producto = producto;
            this.cantidad = cantidad;
            this.pedido = pedido;
            this.totalIndividual = totalIndividual;
        }

        // Getters & Setters

        public int IdItem
        {
            get {  return idItem; }
            set { idItem = value; }
        }

        public Producto Producto 
        { 
            get { return producto; }
            set { producto = value; }
        }

        public int Cantidad
        { 
            get { return cantidad; } 
            set { cantidad = value; } 
        }

        public Pedido Pedido
        {
            get { return pedido; }
            set { pedido = value;  }
        }

        public decimal TotalIndividual()
        {
            decimal totalIndividual = producto.Precio*cantidad;
            return totalIndividual;
        }

        public override string ToString()
        {
            return producto.Nombre +" "+ "x"+ cantidad +" $"+ TotalIndividual();
        }
    }
}
