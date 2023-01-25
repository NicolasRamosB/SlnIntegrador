using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    [Table("Medico")]
    public class Medico : PersonaBase
    {

        [Column(TypeName = "varchar")]
        [Required]
        [StringLength(50)]
        public string Especialidad { get; set; }

        [Column(TypeName = "varchar")]
        [Required]
        [StringLength(50)]

        public string Matricula { get; set; } 

        public List<Paciente> Paciente { get; set; }

    }

}
