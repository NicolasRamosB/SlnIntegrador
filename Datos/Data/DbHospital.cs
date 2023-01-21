using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Models;

namespace Datos
{
    public class DbHospital : DbContext 
    {
        public DbHospital() : base("KeyDB") { }

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Paciente { get; set;}
        public DbSet<Habitacion> Habitacion { get; set;}


    }
}
