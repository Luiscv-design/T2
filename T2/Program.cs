
using T2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace T2
{
    internal class Program
    {             
        public void Main(string[] args)
        {
            ARBOLBB arbolpersonas = new ARBOLBB();
            int opcion;
            do
            {           
                Console.WriteLine("=============== Bienvenido a la  Reniec ==========");

                Console.WriteLine("1) AGREGAR PERSONAS");
                Console.WriteLine("2) LISTAR PERSONAS");
                Console.WriteLine("3) MAYORES DE CIERTA EDAD");
                Console.WriteLine("4) MOSTRAR ANTEPENULTIMO");

                Console.WriteLine("\nIngrese la opcion que desee:");

                Console.ReadKey();

                if (!int.TryParse(Console.ReadLine(), out opcion)) continue;
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("INGRESE EL NOMBRE DE LA PERRSONA:");                     
                            string nombre = Console.ReadLine();
                            Console.WriteLine("=============================================");
                            Console.WriteLine("INGRESE la EDAD DE LA PERRSONA:");
                            int Edad = int.Parse(Console.ReadLine());
                            Console.WriteLine("=============================================");
                            Console.WriteLine("INGRESE EL DNI DE LA PERRSONA:");
                            int Dni = int.Parse(Console.ReadLine());
                            Console.WriteLine("Se ingresó correctamente el dato");
                            arbolpersonas.Agrega(Dni);
                            arbolpersonas.Agrega(Edad);                         
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("La lista de personas: ");
                            arbolpersonas.ImprimePre();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("La mayor cantidad de personas:");
                            arbolpersonas.CantidadMayores();
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("El antepenultimo persona es: ");

                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Fin del programa, Gracias por su compra :)");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opción inválida, Indroduzca nuevamente los datos");
                            Console.ReadKey();
                            break;
                        }
                    



                }
            } while (opcion != 0);  

            Console. ReadLine();
        }       
    }
}
