using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Base;
            double altura;
            double result;

            //base
            Console.WriteLine("valor da base");
            Base = double.Parse(Console.ReadLine());
            //altura
            Console.WriteLine("valor da altura");
            altura = double.Parse(Console.ReadLine());

            // result
            result = Base * altura / 2;
            Console.WriteLine("valor da area é {0}", result);
        }
    }
}
