using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
     class Granja
    {
        public int dinero = 100;
        public int espacio = 5;

        public List<Planta> plantas = new List<Planta>();
        public List<Animal> animales = new List<Animal>();
        public List<Venta> ventasPendientes = new List<Venta>();

        public void ComprarPlanta(Planta planta)
        {
            plantas.Add(planta);
            Console.WriteLine("Compraste planta");
        }

        public void ComprarAnimal(Animal animal)
        {
            animales.Add(animal);
            Console.WriteLine("Compraste animal");
        }

        public void PasarTurno()
        {
            Console.WriteLine(" Nuevo Día ");

            foreach (var planta in plantas)
            {
                planta.Crecer();
            }

            foreach (var animal in animales)
            {
                animal.PasarDia();
                animal.Producir();
            }
        }

    }
}
