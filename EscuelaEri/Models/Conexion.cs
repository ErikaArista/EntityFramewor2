using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscuelaEri.Models
{
    public class Conexion
    {
        public int Id { get; set; }
        public Alumnos alumnos { get; set; }
        public Grupos grupos { get; set; }
    }
}