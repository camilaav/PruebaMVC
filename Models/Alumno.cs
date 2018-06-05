using System;
using System.Collections.Generic;

namespace PruebaMVC.Models
{
    public class Alumno
    {
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public Alumno(string nombre, string apellido)
        {
            Nombre=nombre;
            Apellido=apellido;
        }
    }
    public class Data
    {
        public static List<Alumno> Lista = new List<Alumno>();
    }
}