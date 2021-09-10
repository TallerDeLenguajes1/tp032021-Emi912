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
        private static int id = 0;
        private static Cadeteria miCadeteria = new Cadeteria("Pico Limitos", "Congreso y Aristobulo");
        public IActionResult Index()
        {
          
            return View();
        }

        public IActionResult AltaCadetes(string nombre,string direccion, string telefono)
        {
            Cadete nuevoCadete = new Cadete(id, nombre,direccion, telefono);
            id++;
            miCadeteria.ListadoCadetes.Add(nuevoCadete);
            return View(miCadeteria);
        }
    }
}
