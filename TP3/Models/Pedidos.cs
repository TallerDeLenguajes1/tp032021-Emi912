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

        public Pedidos(string idPedido, string observacion, string dni, string direccion, string telefono, string nombreCliente)
        {
            nroPedido = Convert.ToInt32(idPedido);
            this.observacion = observacion;
            this.cliente = new Cliente(dni, direccion, nombreCliente, telefono);
            estadoPedido = 0;
        }
    }
}
