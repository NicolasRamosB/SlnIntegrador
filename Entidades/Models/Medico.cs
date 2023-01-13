using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Medico : PersonaBase
    {
        public string Especialidad { get; set; }
        public string Matricula { get; set; }
    }

}
