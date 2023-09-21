using System;
using System.Runtime.Serialization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            int Valor1, Valor2, PROD;

            Valor1 = int.Parse(Console.ReadLine());
            Valor2 = int.Parse(Console.ReadLine());

            PROD = Valor1 * Valor2;

            Console.WriteLine("PROD = " + (PROD));

            Console.ReadLine();

            
        }
    }
}
