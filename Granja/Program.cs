using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Granja granja = new Granja();

            while (true)
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1. Comprar planta");
                Console.WriteLine("2. Comprar animal");
                Console.WriteLine("3. Cosechar");
                Console.WriteLine("4. Recolectar");
                Console.WriteLine("5. Ampliar granja");
                Console.WriteLine("6. Pasar turno");
                Console.WriteLine("7. Salir");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Planta p = new Planta();
                    p.nombre = "Zanahoria";
                    p.diasParaCrecer = 2;
                    granja.ComprarPlanta(p);
                }
                else if (opcion == 2)
                {
                    Animal a = new Animal();
                    a.nombre = "Vaca";
                    a.diasParaProducir = 3;
                    granja.ComprarAnimal(a);
                }
                else if (opcion == 3)
                {
                    granja.Cosechar();
                }
                else if (opcion == 4)
                {
                    granja.RecolectarAnimales();
                }
                else if (opcion == 5)
                {
                    granja.AmpliarGranja();
                }
                else if (opcion == 6)
                {
                    granja.PasarTurno();
                }
                else if (opcion == 7)
                {
                    break;
                }

            }
        }
    }
}

