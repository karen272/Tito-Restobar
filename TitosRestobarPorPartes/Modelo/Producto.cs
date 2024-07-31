using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Alonso Melina Karen Celes


namespace TitosRestobarPorPartes.Modelo
{
    internal class Producto
    {
        private int idproducto;
        private string nombre;
        private string descripcion;
        private decimal precio;
        private decimal costo;
        private bool elaborado;


        //Constructores

        public Producto()
        {

        }

        public Producto(int idproducto, string nombre, string descripcion, decimal precio, decimal costo, bool elaborado)
        {
            this.IdProducto = idproducto;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Costo = costo;
            this.Elaborado = elaborado;
        }



        //Getters y Setters
        public int IdProducto
        {
            get { return idproducto; }
            set { idproducto = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public decimal Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public bool Elaborado
        {
            get { return elaborado; }
            set { elaborado = value; }
        }

        public override string ToString()
        {
            return Nombre + " " + Descripcion +" "+Precio;
        }
    }
}
