using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
     class Animal:IProducible
    {
        public string nombre;
        public int diasParaProducir;
        public int diasActuales = 0;

        public void PasarDia()
        {
            diasActuales++;
        }

        public void Producir()
        {
            if (diasActuales >= diasParaProducir)
            {
                Console.WriteLine(nombre + " produjo algo");
                diasActuales = 0;
            }
        }
    }
}
