using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Dolar
    {
        public float cantidad;

        private Dolar(int valor)
        {
            this.cantidad = valor;
        }

        public static Dolar operator +(Dolar unDolar, Peso unPeso)
        {
            unDolar.cantidad = unDolar.cantidad + (unPeso.cantidad / 15);
            return unDolar;
        }

        public static implicit operator Dolar(int valor)
        {
            return new Dolar(valor);
        }
    }
}
