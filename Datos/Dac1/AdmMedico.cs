using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades.Models;

namespace Negocio
{
    public static class AdmMedico
    {
        private static DbHospital context = new DbHospital();
       

        public static List<Medico> ListarTodo()
        {
            
            return context.Medicos.ToList();
        }

        public static Medico ListarPorEspecialidad(string especialidad)
        {
            
            
            return context.Medicos.Find(especialidad);

        }
        public static int Insertar(Medico medico)
        {
            context.Medicos.Add(medico);
            return context.SaveChanges();
        }
        public static int Eliminar(int id)
        {
            Medico medicoOrigen = context.Medicos.Find(id);
            if (medicoOrigen != null)
            {
                context.Medicos.Remove(medicoOrigen);
                return context.SaveChanges();
            }
            return 0;
        }

        public static Medico TraerUno(int id)
        {
            
            return context.Medicos.Find(id);
        }

        

    }
}
