using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Alonso Melina Karen Celes


namespace TitosRestobarPorPartes.Modelo
{
    internal class Pedido
    {
        private int idPedido;
        private DateTime fechayHoraApertura;
        private DateTime fechayHoraCierre;
        private Mesa mesa;

        //Constructores 
        public Pedido()
        {

        }
        public Pedido(int idPedido, DateTime fechayHoraApertura, DateTime fechayHoraCierre, Mesa mesa)
        {
            this.IdPedido = idPedido;
            this.FechayHoraApertura = fechayHoraApertura;
            this.FechayHoraCierre = fechayHoraCierre;
            this.Mesa = mesa;
        }

        // Getters y Setters

        public Mesa Mesa
        {
            get { return mesa; }
            set { mesa = value; }
        }

        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }

        public DateTime FechayHoraApertura
        {
            get { return fechayHoraApertura; }
            set { fechayHoraApertura = DateTime.UtcNow; } //ver despues  
        }
        public DateTime FechayHoraCierre
        {
            get { return fechayHoraCierre; }
            set { fechayHoraCierre = DateTime.UtcNow; } //ver despues  
        }


        public override string ToString()
        {
            return " " + fechayHoraApertura + " " + fechayHoraCierre;
        }



    }
}
