using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP3.Models;

namespace TP3.Controllers
{
    public class PedidoController : Controller
    {
        private readonly DBTemp _db;
        private static int idClient;

        public PedidoController(DBTemp db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
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

        public IActionResult AltaPedidos(string nombre, string direccion, string telefono, string obs, int _id)
        {
            foreach (var item in _db.MiCadeteria.ListadoCadetes)
            {
                if (_id == item.Id)
                {
                    idClient = _db.MiCadeteria.ListadoPedidos.Count + 1;
                    Cliente cliente = new Cliente(idClient, direccion, nombre, telefono);
                    Pedidos nuevoPedido = new Pedidos(obs, cliente);
                    _db.MiCadeteria.AddPedido(nuevoPedido);
                    item.AddPedido(nuevoPedido);
                    _db.GuardarDatos();
                    return RedirectToAction("ShowPedidos", new { id = _id });
                }
            }

            return View("ErrorViewModel");

        }

        public IActionResult Edit(int idPedido)         //Busca el pedido y muestra form para editar
        {
            foreach (var cadete in _db.MiCadeteria.ListadoCadetes)
            {
                foreach (var pedido in cadete.ListadoPedidos)
                {
                    if (idPedido == pedido.Cliente.Id)
                    {
                        return View(pedido);
                    }
                }
            }
           

            return View("ErrorViewModel");
        }


        public IActionResult GuardarEdit(string nombre, string obs, string telefono, int _id, Estado estado)         //Modificar el Pedido
        {
            foreach (var cadete in _db.MiCadeteria.ListadoCadetes)
            {
                foreach (var pedido in cadete.ListadoPedidos)
                {
                    if (_id == pedido.Cliente.Id)
                    {
                        pedido.Cliente.Nombre = nombre;
                        pedido.Cliente.Telefono = telefono;
                        pedido.Observacion = obs;
                        pedido.EstadoPedido = estado;
                        _db.GuardarDatos();
                        return RedirectToAction("ShowPedidos", new { id =  cadete.Id});
                    }
                }
            }

            return View("ErrorViewModel");

            
        }

        public IActionResult Delete(int idPedido)                             //Eliminar el pedido
        {
            foreach (var cadete in _db.MiCadeteria.ListadoCadetes)
            {
                foreach (var pedido in cadete.ListadoPedidos)
                {
                    if (idPedido == pedido.Cliente.Id)
                    {
                        cadete.ListadoPedidos.Remove(pedido);
                        _db.GuardarDatos();
                        return RedirectToAction("ShowPedidos", new { id = cadete.Id });
                    }
                }
            }

            return View("ErrorViewModel");
        }


    }


}
