using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    class Planta:Producto
    {
        public int diasParaCrecer;
        public int diasActuales = 0;

        public void Crecer()
        {
            diasActuales++;
        }

        public bool ListaParaCosechar()
        {
            return diasActuales >= diasParaCrecer;
        }

        public override void Vender()
        {
            Console.WriteLine("Vendiste la planta: " + nombre);
        }
    }
}
