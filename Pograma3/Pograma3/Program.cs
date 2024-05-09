using System;


namespace Pograma3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            string linea;

            Console.Write("Ingrese un numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            if (num1 < 10)
            {

                Console.WriteLine($"El numero { num1} tiene un digito");

            }
            else
            {

                Console.WriteLine($"El numero {num1} tiene dos digitos");

            }

            Console.ReadKey();
        }
    }
}
