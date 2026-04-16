using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    abstract class Producto
    {
        public string nombre;
        public int precioVenta;

        public abstract void Vender();

    }
}
