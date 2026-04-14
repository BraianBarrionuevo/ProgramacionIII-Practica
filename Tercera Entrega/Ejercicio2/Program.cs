using System;
namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ejercicio1: Colores
            Console.WriteLine("--- EJERCICIO: COLORES ---");

            string[] colores = { "Rojo", "Azul", "Verde", "Amarillo" };

            Console.WriteLine("Lista de colores:");

            foreach (string color in colores)
            {
                Console.WriteLine("- " + color);
            }

            Console.ReadLine();


           
            // Ejercicio2: Países
            Console.WriteLine("--- EJERCICIO: PAISES ---");

            string[] paises = { "Argentina", "Brasil", "Chile", "Uruguay" };

            Console.WriteLine("Lista de países:");

            foreach (string pais in paises)
            {
                Console.WriteLine("- " + pais);
            }

            Console.ReadLine();
        
            // Ejercicio3: Animales
            Console.WriteLine("--- EJERCICIO: ANIMALES ---");

            string[] animales = { "Perro", "Gato", "Elefante", "León" };

            Console.WriteLine("Lista de animales:");

            foreach (string animal in animales)
            {
                Console.WriteLine("- " + animal);
            }

            Console.ReadLine();

            // Ejercicio4: Numeros Pares
            Console.WriteLine("--- EJERCICIO: NUMEROS PARES ---");

            int[] numerosPares = { 2, 4, 6, 8, 10 };

            Console.WriteLine("Lista de números pares:");

            foreach (int numero in numerosPares)
            {
                Console.WriteLine("- " + numero);
            }

            Console.ReadLine();

            // Ejercicio5: Materias
            Console.WriteLine("--- EJERCICIO: MATERIAS ---");

            string[] materias = { "Matemáticas", "Historia", "Ciencias", "Literatura" };

            Console.WriteLine("Lista de materias:");

            foreach (string materia in materias)
            {
                Console.WriteLine("- " + materia);
            }

            Console.ReadLine();
            
        }
    }
}