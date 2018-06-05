using System;
using Microsoft.AspNetCore.Mvc;
using PruebaMVC.Models;
using System.Collections.Generic;

namespace MVCNuevo.Controllers
{
    public class AlumnoController : Controller
    {

        public IActionResult VoyACrear()
        {
            return View();
        }
        
        [HttpPost]        
        public IActionResult Crear(Alumno alumno)
        {
            Data.Lista.Add(alumno);
            var list = new List<Alumno>();
            list.Add(new Alumno("Camila","Verni"));
            list.Add(new Alumno("Cecilia","Guerreiro"));
            list.Add(new Alumno("Valeria","Verni"));
            return View();

        }        
        public IActionResult Borrar()
        {
            Data.Lista.Clear();
            return View();
        }
        public IActionResult BorrarUno(string nombre)
        {
            int index = Data.Lista.FindIndex( a => a.Nombre == nombre);
            Data.Lista.RemoveAt(index);
            return View("Borrar");
        }
    }
}