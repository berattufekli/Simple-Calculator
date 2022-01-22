using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    internal class Calculate
    {
        public double Topla(double a, double b)
        {
            return a + b;
        }

        public double Cikar(double a, double b)
        {
            return (a - b);
        }

        public double Carpma(double a, double b)
        {
            return (a * b);
        }

        public double Bolme(double a, double b)
        {
            return (a / b);
        }
    }
}
