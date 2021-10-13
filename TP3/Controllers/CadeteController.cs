using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private readonly DBTemp _db;
        public CadeteController(DBTemp db)
        {
            _db = db;
        }
        public IActionResult Index() 
        {

            return View();
        }

        public IActionResult AltaCadetes(string nombre,string dni, string direccion, string telefono)               //Metodo para dar alta un Cadete
        {
            if (nombre != null || direccion != null || telefono != null || dni != null)
            {
                idCadete = _db.MiCadeteria.ListadoCadetes.Count + 1;
                Cadete nuevoCadete = new Cadete(idCadete, nombre, direccion, telefono, dni);

                _db.MiCadeteria.AddCadete(nuevoCadete);
                _db.GuardarDatos();    // Guardo en el Json
            }

            return View(_db.MiCadeteria);
        }



        public IActionResult Edit(int id)                                   
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


        public IActionResult GuardarEdit(string nombre, string dni, string direccion, string telefono, int _id)         //Modificar el cadete
        {
            foreach (var item in _db.MiCadeteria.ListadoCadetes)
            {
                if (item.Id == _id)
                {
                    item.Direccion = direccion;
                    item.Dni = dni;
                    item.Telefono = telefono;
                    item.Nombre = nombre;
                    _db.GuardarDatos();             // Guardo en el Json
                }
            }
            

            return Redirect("AltaCadetes");
        }

        public IActionResult Delete(int id)                             //Eliminar un Cadete
        {
            foreach (var item in _db.MiCadeteria.ListadoCadetes)
            {
                if (item.Id == id)
                {
                    _db.MiCadeteria.ListadoCadetes.Remove(item);                //Remuevo el cadete del listado de cadetes
                    idCadete = _db.MiCadeteria.ListadoCadetes.Count;
                    _db.GuardarDatos();                     // Guardo en el Json
                    break;
                }
            }
            return RedirectToAction("AltaCadetes", "Cadete");
        }
    }
}
