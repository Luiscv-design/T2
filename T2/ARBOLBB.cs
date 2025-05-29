using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class ARBOLBB
    {      
            public NodoP Raiz { get; set; }

            public ARBOLBB()
            {
                Raiz = null;
            }

            public void Agrega(int valor)
            {             
                if (Raiz == null)
                {
                    Raiz = new NodoP(valor);
                }
                else
                {
                   
                    Agregapersona(Raiz, valor);
                }
            }

            private void Agregapersona(NodoP actual, int valor)
            {              
                if (actual.Dato == valor)
                {
                    return;
                }
                else if (valor < actual.Dato)
                {
                    
                    if (actual.Izq == null)
                    {
                        actual.Izq = new NodoP(valor);
                        return;
                    }
                    else
                    {
                        Agregapersona(actual.Izq, valor);
                    }
                }
                else
                {                  
                    if (actual.Der == null)
                    {
                        actual.Der = new NodoP(valor);
                        return;
                    }
                    else
                    {
                        Agregapersona(actual.Der, valor);
                    }
                }

            }


            public void ImprimePre()
            {
                ImprimePreNodo(Raiz);
                Console.WriteLine();
            }
            public void ImprimePreNodo(NodoP n)
            {
                if (n != null)
                {
                    Console.Write(n.Dato + ", ");
                    ImprimePreNodo(n.Izq);
                    ImprimePreNodo(n.Der);
                }
            }
           
            public void CantidadMayores()
            {
                int edad = EncontrarMayor(Raiz);
                Console.Write("Cantidad de personas mayores es de: " + edad );
            }
            public int EncontrarMayor(NodoP n)
            {
                if (n == null)
                    return int.MinValue;

                int valor = n.Dato;
                int maxDer = EncontrarMayor(n.Der);

                return Math.Max(valor, maxDer);
            }
            public void antepenultimo()
            {
              int pe = encontarantepenultimo(Raiz);
             Console.WriteLine("El altepenultimo persona es: " + pe);
            }  
             public int encontarantepenultimo()
             {
              if ()
              
             }
        
    }
}
