using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    [Table("Medico")]
    public class Medico : PersonaBase
    {
        public int IdMedico { get; set; }
        public string Especialidad { get; set; }
        public string Matricula { get; set; }
    }

}
