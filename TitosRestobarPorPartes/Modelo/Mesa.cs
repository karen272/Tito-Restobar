using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitosRestobarPorPartes.Modelo
{
    internal class Mesa
    {
        private int IdMesa;
        private string NombreMesa;
        private Pedido Pedido;

        //constructores
        public Mesa()
        {

        }

        public Mesa(int idMesa, string nombreMesa, Pedido pedido)
        {
            this.IdMesa = idMesa;
            this.NombreMesa = nombreMesa;
            this.Pedido = pedido;

        }

        //getters y Setters

        public int idMesa
        {
            get 
            {
                return this.IdMesa;
            }
            set
            {
                IdMesa = value;
            }

        }
        public string nombreMesa
        {
            get
            {
                return this.NombreMesa;
            }
            set
            {  
                this.NombreMesa = value;
            }
        }

        public Pedido pedido
        {
            get
            {
                return this.pedido;
            }
            set
            { 
                this.pedido = value;
            }
        }

        public override string ToString()
        {
            return nombreMesa + " ";
        }


    }
}
