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
            List<Habitacion> listaHabitacion = new List<Habitacion>();
            listaHabitacion.Add(new Habitacion() { Id = 1, Numero = 134, Estado = true });
            listaHabitacion.Add(new Habitacion() { Id = 2, Numero = 20, Estado = false });
            listaHabitacion.Add(new Habitacion() { Id = 3, Numero = 394, Estado = true });
            listaHabitacion.Add(new Habitacion() { Id = 4, Numero = 100, Estado = false });
            listaHabitacion.Add(new Habitacion() { Id = 5, Numero = 10, Estado = true });

            return listaHabitacion;
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
