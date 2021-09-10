using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP3.Models
{
    public class Cadeteria
    {
        private string nombre;
        private string direccion;
        private List<Cadete> listadoCadetes;
        private int gastos;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public List<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }
        public int Gastos { get => gastos; set => gastos = value; }

        public Cadeteria(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            listadoCadetes = new List<Cadete>();
        }

        public void CalcularGastos()
        {
            
            foreach (var item in listadoCadetes)
            {
                gastos += item.ListadoPedidos.Count * 100;
            }


        }
    }
}
