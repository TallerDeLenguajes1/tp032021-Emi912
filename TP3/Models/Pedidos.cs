using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP3.Models
{
    public enum Estado
    {
        EnCamino,
        Entregado,
        Cancelado
    }
    public class Pedidos
    {
        private int nroPedido;
        private string observacion;
        private Cliente cliente;
        private Estado estadoPedido;

        public int NroPedido { get => nroPedido; set => nroPedido = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Estado EstadoPedido { get => estadoPedido; set => estadoPedido = value; }

        public Pedidos(int nroPedido, string observacion, Cliente cliente)
        {
            this.nroPedido = nroPedido;
            this.observacion = observacion;
            this.cliente = cliente;
            estadoPedido = 0;
        }
    }
}
