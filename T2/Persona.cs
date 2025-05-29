using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public int Dni { get; set; }

        public Persona(int dato)
        {
            Dni = dato;
        }      
    }
}
