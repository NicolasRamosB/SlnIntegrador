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
        public DbSet<Paciente> Pacientes { get; set;}
        public DbSet<Habitacion> Habitaciones { get; set;}


    }
}
