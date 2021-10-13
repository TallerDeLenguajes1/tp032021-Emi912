using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP3.Models
{
    public class Cadete
    {
        private int id;
        private string dni;
        private string nombre;
        private string direccion;
        private string telefono;
        private List<Pedidos> listadoPedidos;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public List<Pedidos> ListadoPedidos { get => listadoPedidos; set => listadoPedidos = value; }
        public string Dni { get => dni; set => dni = value; }

        public Cadete(int id, string nombre, string direccion, string telefono, string dni)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.Dni = dni;
            listadoPedidos = new List<Pedidos>();
        }

        public void AddPedido(Pedidos nuevoPedido)
        {
            listadoPedidos.Add(nuevoPedido);
        }

        public void RemovePedido(Pedidos pedido)
        {
            listadoPedidos.Remove(pedido);
        }
    }
}
