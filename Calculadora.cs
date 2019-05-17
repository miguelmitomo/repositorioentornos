using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEntornos
{
    class Calculadora
    {
        /// <summary>
        /// suma
        /// </summary>
        /// <param name="a">valor a</param>
        /// <param name="b">valor b</param>
        /// <returns></returns>
        public static int suma(int a,int b)
        {
            int result;
            result = a + b;
            return result;
        }


        public static int mult(int a, int b)
        {
            int result;
            result = a * b + 1;

            return result;
        }
    }
}
