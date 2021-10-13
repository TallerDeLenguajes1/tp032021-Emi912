using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TP3.Models
{
    public enum Estado
    {
        [Description("En Camino")]
        EnCamino,
        Entregado,
        Cancelado
    }
    public class Pedidos
    {
        private string observacion;
        private Cliente cliente;
        private Estado estadoPedido;

        public string Observacion { get => observacion; set => observacion = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Estado EstadoPedido { get => estadoPedido; set => estadoPedido = value; }

        public Pedidos(string observacion, Cliente cliente)
        {
            this.observacion = observacion;
            this.cliente = cliente;
            estadoPedido = 0;
        }
    }
}
