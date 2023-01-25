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
    public static class AdmHabitacion
    {
        private static DbHospital context = new DbHospital();
        public static List<Habitacion> Listar()
        {
            return context.Habitaciones.ToList();
        }

        public static Habitacion Listar(string estado)
        {
            
            return context.Habitaciones.Find(estado);

        }
        public static int Insertar(Habitacion Habitacion)
        {
            context.Habitaciones.Add(Habitacion);
            return context.SaveChanges();
        }
        public static int Eliminar(int id)
        {
            Habitacion habitacion = context.Habitaciones.Find(id);
            if (habitacion != null)
            {
                context.Habitaciones.Remove(habitacion);
                return context.SaveChanges() ;  
            }
            return 0;
        }

        public static Habitacion TraerUno(int numero)
        {
           
            return context.Habitaciones.Find(numero);
        }

    }
}
