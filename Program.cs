using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOVIERNESSEM1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la operación que quiere usar:");
            Console.WriteLine("1. Número mayor o menor");
            Console.WriteLine("2. Números primos");
            string oper = Console.ReadLine();

            switch (oper)
            {
                case "1":
                    ProcesarNumeros();
                    break;
                case "2":
                    ProcesarPrimos();
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            // Mantener la consola abierta hasta que el usuario presione una tecla
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        private static void ProcesarNumeros()
        {
            int[] numeros = LeerNumeros();
            NumeroMayor(numeros);
            NumeroMenor(numeros);
        }

        private static int[] LeerNumeros()
        {
            int[] numeros = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Dame el número {i + 1}:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numeros;
        }

        private static void NumeroMayor(int[] numeros)
        {
            int mayor = numeros.Max();
            Console.WriteLine($"El número mayor es: {mayor}");
        }

        private static void NumeroMenor(int[] numeros)
        {
            int menor = numeros.Min();
            Console.WriteLine($"El número menor es: {menor}");
        }

        private static void ProcesarPrimos()
        {
            Console.WriteLine("Dame un número:");
            int N = Convert.ToInt32(Console.ReadLine());

            if (EsPrimo(N))
            {
                Console.WriteLine($"{N} es un número primo.");
            }
            else
            {
                Console.WriteLine($"{N} no es un número primo.");
            }
        }

        private static bool EsPrimo(int N)
        {
            if (N <= 1) return false;
            if (N == 2) return true;

            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0) return false;
            }
            return true;
        }
    }
}