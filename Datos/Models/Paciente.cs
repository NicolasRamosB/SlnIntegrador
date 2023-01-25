﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades.Models
{
    public class Paciente : PersonaBase
    {
        public int NroHistorialClinica { get; set; }

        public int MedicoId { get; set; }
        [ForeignKey("MedicoId")]
        public Medico Medico { get; set; }


        public int HabitacionId { get; set; }
        [ForeignKey("HabitacionId")]
        public Habitacion Habitacion { get; set; }
    }

}
