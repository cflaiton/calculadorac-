using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operaciones
    {

        public double suma (double a, double b)
        {
            double resultado;
            resultado = a + b;
            return resultado;

        }

        public double resta(double a, double b)
        {
            double resultado;
            resultado = a - b;
            return resultado;

        }
        public double mukltiplicacion(double a, double b)
        {
            double resultado;
            resultado = a * b;
            return resultado;

        }

        public double division(double a, double b)
        {
            double resultado;
            resultado = a / b;
            return resultado;

        }
        public double factorial(double a)
        {
            double resultado=1;

            for (int i = 1; i <= a; i++)
            {
                resultado = resultado*i;
            }

            return resultado;

        }


    }
}
