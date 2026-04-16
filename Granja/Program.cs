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

            Planta zanahoria = new Planta();
            zanahoria.nombre = "Zanahoria";
            zanahoria.diasParaCrecer = 2;

            Animal vaca = new Animal();
            vaca.nombre = "Vaca";
            vaca.diasParaProducir = 3;

            granja.ComprarPlanta(zanahoria);
            granja.ComprarAnimal(vaca);

            granja.VenderProducto("Zanahoria", 10);

            for (int i = 0; i < 5; i++)
            {
                granja.PasarTurno();
            }

            Console.ReadLine();

        }
    }
}
