using System;

namespace Programa2
{
     class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, suma, promedio;
            string linea;

            Console.Write("Ingrese la primera nota: ");
            linea = Console.ReadLine();
            nota1 = int.Parse(linea);
            Console.Write("Ingrese la segunda nota :");
            linea = Console.ReadLine();
            nota2 = int.Parse(linea);
            Console.Write("Ingrese la tercera nota :");
            linea = Console.ReadLine();
            nota3 = int.Parse(linea);
            suma = nota1 + nota2 + nota3;
            promedio = suma / 3;

            if (promedio >= 7)
            {
                Console.Write("Promocionado");


            }

            Console.ReadKey();
        }
    }
}
