using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades.Models;

namespace Negocio
{
    public static class AdmPaciente
    {
        private static DbHospital context = new DbHospital();

        public static List<Paciente> Listar()
        {
            return context.Pacientes.ToList();
        }

        public static int Insertar(Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            return context.SaveChanges();
        }
        public static int Eliminar(int id)
        {
            Paciente paciente= context.Pacientes.Find(id);
            if (paciente != null)
            {
                context.Pacientes.Remove(paciente);
                return context.SaveChanges();
            }
            return 0;
        }

        public static Paciente TraerUno(int nroHistoriaClinica)
        {
            
            return context.Pacientes.Find(nroHistoriaClinica);
        }

    }
}
