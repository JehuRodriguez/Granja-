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

        public void VenderProducto(string nombre, int precio)
        {
            Venta venta = new Venta();
            venta.nombreProducto = nombre;
            venta.precio = precio;
            venta.diasRestantes = 2;

            ventasPendientes.Add(venta);

            Console.WriteLine("Venta en proceso de " + nombre);
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

            for (int i = ventasPendientes.Count - 1; i >= 0; i--)
            {
                ventasPendientes[i].diasRestantes--;

                if (ventasPendientes[i].diasRestantes <= 0)
                {
                    Console.WriteLine("Venta completada: " + ventasPendientes[i].nombreProducto);

                    dinero += ventasPendientes[i].precio;
                    ventasPendientes.RemoveAt(i);
                }
            }
        }

        public void Cosechar()
        {
            for (int i = plantas.Count - 1; i >= 0; i--)
            {
                if (plantas[i].ListaParaCosechar())
                {
                    Console.WriteLine("Cosechaste: " + plantas[i].nombre);

                    
                    VenderProducto(plantas[i].nombre, 10);

                    plantas.RemoveAt(i);
                }
            }
        }

        public void RecolectarAnimales()
        {
            foreach (var animal in animales)
            {
                if (animal.listo)
                {
                    Console.WriteLine("Recolectaste producto de: " + animal.nombre);

                    VenderProducto(animal.nombre, 15);

                    animal.listo = false;
                }
            }
        }
    }
}
