using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitosRestobarPorPartes.Modelo
{
    internal class Stock
    {
        private Producto producto;
        private int cantidad;
        private int idStock;

        public Stock()
        {

        }

        public Stock(Producto producto, int cantidad, int idStock)
        {
            this.producto = producto;
            this.cantidad = cantidad;
            this.idStock = idStock;
        }

        public Producto Producto
        {
            get
            {
                return producto;
            }
            set
            {
                producto = value;
            }
        }
        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }

        public int IdStock
        {
            get
            {
                return idStock;
            }
            set
            {
                idStock = value;
            }
        }

        public override string ToString()
        {
            return producto.Nombre + "" + Cantidad + "";
        }
    }
}
