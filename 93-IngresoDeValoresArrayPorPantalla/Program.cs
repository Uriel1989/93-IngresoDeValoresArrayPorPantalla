using System;

//Ingreso de valores por pantalla y lo muestra

namespace _93_IngresoDeValoresArrayPorPantalla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa 3 valores para el array propuesto:");

            int[] array = new int[3];

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            array[0] = a;
            array[1] = b;
            array[2] = c;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("El valor de la posicion " + i + " es " + array[i]);
            }
        }
    }
}
