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
            Console.WriteLine("Welcome to the Quadratic Equation Solver!");
            Console.WriteLine("The equation format is: ax^2 + bx + c = 0");

            // Step 1: Get coefficients from the user
            Console.Write("Enter the value of a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Step 2: Check if 'a' is zero
            if (a == 0)
            {
                Console.WriteLine("The value of 'a' cannot be 0 for a quadratic equation.");
                return; // Exit the program
            }

            // Step 3: Calculate the discriminant (D = b^2 - 4ac)
            double discriminant = Math.Pow(b, 2) - (4 * a * c);

            // Step 4: Determine the nature of the roots
            if (discriminant > 0)
            {
                // Two distinct real roots
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine("The equation has two real and distinct roots:");
                Console.WriteLine($"Root 1: {root1:F2}");
                Console.WriteLine($"Root 2: {root2:F2}");
            }
            else if (discriminant == 0)
            {
                // One repeated real root
                double root = -b / (2 * a);

                Console.WriteLine("The equation has one real and repeated root:");
                Console.WriteLine($"Root: {root:F2}");
            }
            else
            {
                // Two complex roots
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);

                Console.WriteLine("The equation has two complex roots:");
                Console.WriteLine($"Root 1: {realPart:F2} + {imaginaryPart:F2}i");
                Console.WriteLine($"Root 2: {realPart:F2} - {imaginaryPart:F2}i");
            }

            
            Console.WriteLine("Thanks for using the Quadratic Equation Solver!");

            Console.ReadLine(); 
        }
    }
}
