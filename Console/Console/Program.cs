using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers addition");
            Console.Write("Enter first digit: ");
            var FirstNumber = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter second digit: ");
            var SecondNumber = Convert.ToDecimal(Console.ReadLine());
            var Sum = FirstNumber + SecondNumber;
            Console.WriteLine(
                String.Format("{0} + {1} = {2}",
                FirstNumber, SecondNumber, Sum)
                );
        }
    }
}
