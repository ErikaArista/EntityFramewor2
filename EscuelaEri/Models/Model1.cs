using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EscuelaEri.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=BDerika")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<Alumnos> Alumnos { get; set; }
        public virtual DbSet<Grupos> Grupos { get; set; }
    }
}
