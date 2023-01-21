using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Director : PersonaBase
    {
       
        public int Matricula { get; set; }
        public string Especialidad { get; set; }
        public string Postgrado { get; set; }
        public int MyProperty { get; set; }
      

    }

}
