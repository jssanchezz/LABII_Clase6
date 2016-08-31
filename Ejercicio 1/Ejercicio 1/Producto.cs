using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Producto
    {
        private int _cantidad;

        private Producto(int valor)
        {
            this._cantidad = valor;
        }

        public static Producto operator +(Producto auxProducto, int valor)
        {
            auxProducto._cantidad = auxProducto._cantidad + valor;
            return auxProducto;
        }

        public static Producto operator +(Producto auxProducto, Producto prod)
        {
            auxProducto._cantidad = auxProducto._cantidad + prod._cantidad;
            return auxProducto;
        }

        /*public static explicit operator Producto(int valor)
        {
            
        }*/

        public static implicit operator Producto(int valor)
        {
            return new Producto(valor);
        }
    }
}
