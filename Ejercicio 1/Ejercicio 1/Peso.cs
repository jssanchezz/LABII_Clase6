using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Peso
    {
        public float cantidad;

        private Peso(int valor)
        {
            this.cantidad = valor;
        }

        public static Peso operator +(Peso unPeso, Dolar unDolar)
        {
            unPeso.cantidad = unPeso.cantidad + (unDolar.cantidad * 15);
            return unPeso;
        }

        public static explicit operator Peso(int valor)
        {
            return new Peso(valor);
        }
    }
}
