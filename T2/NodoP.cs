using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class NodoP
    {
        
      
            public NodoP Izq { get; set; }
            public NodoP Der { get; set; }
            public int Dato { get; set; }

            public NodoP(int dato)
            {
                Dato = dato;
            }

                
    }
}
