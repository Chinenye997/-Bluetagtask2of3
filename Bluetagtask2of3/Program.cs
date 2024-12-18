using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluetagtask2of3
{
    class QuadraticFormula
    {
        static void Main(string[] args)
        {

            /* int count = 9;
             int count2 = 10;
             int factor = 3; */

            Console.WriteLine("Enter the first number? ");
            string first = Console.ReadLine();

            Console.WriteLine("Enter the second number? ");
            string second = Console.ReadLine();

            Console.WriteLine("Enter the factor? ");
            string fact = Console.ReadLine();

            int count = int.Parse(first);
            float count2 = float.Parse(second);
            double factor = double.Parse(fact); // you also do with decimal of 2.5;


            Console.WriteLine(count2 + count);
            Console.WriteLine(count%factor);
            Console.WriteLine((count2 + count) * factor);// you can still do it this way

             Console.WriteLine(count2 + factor);


            // you can do Math.Pow also sqrt
            Console.WriteLine(Math.Pow(count, factor));
            Console.WriteLine(Math.Sqrt(count));
            Console.ReadLine();
        }
    }
}
