using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP3.Models
{
    public class Cliente
    {
        private string id;
        private string nombre;
        private string direccion;
        private string telefono;

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public Cliente(string dni, string direccion, string nombre, string telefono)
        {
            this.id = dni;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;

        }
    }
}
