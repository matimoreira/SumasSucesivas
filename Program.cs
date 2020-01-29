using System;

namespace SumasSucesivas
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, producto = 0;
            Console.Write("Ingresar un valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresar un valorpor el que desea multiplicar el anterior: ");
            valor2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < valor2; i++)
            {
                producto += valor1; 
            }
            Console.Write("El producto de ambos valores es: " + producto.ToString());
        }
    }
}
