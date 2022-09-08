using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscuelaEri.Models
{
    public class Grupos
    {
        public int Id { get; set; }
        public string Carrera { get; set; }
        public int Cuatrimestre { get; set; }
        public int Grupo { get; set; }
        public Alumnos alumnos { get; set; }
    }
}