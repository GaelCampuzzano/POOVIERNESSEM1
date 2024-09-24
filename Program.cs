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
            string oper;
            do
            {
                Console.Clear(); // Limpia la consola antes de mostrar el menú
                Console.WriteLine("Ingrese la operación que quiere usar:");
                Console.WriteLine("1. Número mayor o menor");
                Console.WriteLine("2. Números primos");
                Console.WriteLine("3. Imprimir solo el número mayor");
                Console.WriteLine("4. Salir");
                oper = Console.ReadLine();

                switch (oper)
                {
                    case "1":
                        ProcesarNumeros();
                        break;
                    case "2":
                        ProcesarPrimos();
                        break;
                    case "3":
                        ImprimirNumeroMayor();
                        break;
                    case "4":
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                if (oper != "4")
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey(); // Espera antes de volver a mostrar el menú
                }
            } while (oper != "4"); // El ciclo se repite hasta que se elija salir (opción 4)
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

        private static void ImprimirNumeroMayor()
        {
            Console.WriteLine("¿Cuántos números quieres ingresar?");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Dame el número {i + 1}:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int mayor = numeros.Max();
            Console.WriteLine($"El número mayor de la lista es: {mayor}");
        }

        private static void ProcesarPrimos()
        {
            Console.WriteLine("Dame un número:");
            int N = Convert.ToInt32(Console.ReadLine());

            MostrarNumerosPrimos(N);
        }

        // método para mostrar todos los números primos desde 1 hasta N
        private static void MostrarNumerosPrimos(int N)
        {
            Console.WriteLine($"Números primos de 1 a {N}:");

            for (int i = 2; i <= N; i++)
            {
                if (EsPrimo(i))
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine(); // Salto de línea después de imprimir los números primos
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