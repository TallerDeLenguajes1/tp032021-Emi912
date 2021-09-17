using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP3.Models;

namespace TP3.Controllers
{
    public class CadeteController : Controller
    {
        private static int idCadete = 1;
        private static int idClient = 1;
        private static int nroPedido = 1;
        private readonly DBTemp _db;
        public CadeteController(DBTemp  db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
          
            return View();
        }

        public IActionResult AltaCadetes(string nombre,string direccion, string telefono)
        {
            if (nombre != null && direccion != null && telefono != null)
            {
                Cadete nuevoCadete = new Cadete(idCadete, nombre, direccion, telefono);
                idCadete++;
                _db.MiCadeteria.AddCadete(nuevoCadete);
                _db.GuardarCadetes();
            }
           
            return View(_db.GetCadetes());
        }

    
        public IActionResult FormPedidos(int id)
        {
            foreach (var item in _db.MiCadeteria.ListadoCadetes)
            {
                if (item.Id == id)
                {
                    return View(item);
                }
            }

            return View("ErrorViewModel");


        }

        public IActionResult AltaPedidos(string nombre, string direccion, string telefono, string obs, int id)
        {
            foreach (var item in _db.MiCadeteria.ListadoCadetes)
            {
                if (id == item.Id)
                {
                    Cliente cliente = new Cliente(id, direccion, nombre, telefono);
                    Pedidos nuevoPedido = new Pedidos(nroPedido, obs, cliente);
                    item.AddPedido(nuevoPedido);
                    _db.GuardarCadetes();
                    return View(item);
                }
            }

            return View("ErrorViewModel");

        }


        public IActionResult ShowPedidos(int id)
        {
            foreach (var item in _db.MiCadeteria.ListadoCadetes)
            {
                if (id == item.Id)
                {
                    return View(item);
                }
            }

            return View("ErrorViewModel");
        }

     

    }
}
