using System;
namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio1: Edades

            Console.WriteLine("--- EJERCICIO: EDADES ---");

            
            int[] edades = new int[3];

            edades[0] = 18;
            edades[1] = 25;
            edades[2] = 30;

            Console.WriteLine("Edad 1: " + edades[0]);
            Console.WriteLine("Edad 2: " + edades[1]);
            Console.WriteLine("Edad 3: " + edades[2]);


            Console.ReadLine();

            // Ejercicio2: Precios

            Console.WriteLine("--- EJERCICIO: PRECIOS ---");

            double[] precios = new double[3];

            precios[0] = 1500.50;
            precios[1] = 2300.75;
            precios[2] = 999.99;

            Console.WriteLine("Precio 1: " + precios[0]);
            Console.WriteLine("Precio 2: " + precios[1]);
            Console.WriteLine("Precio 3: " + precios[2]);

            Console.ReadLine();

            // Ejercicio3: Nombres

            Console.WriteLine("--- EJERCICIO: NOMBRES ---");

            string[] nombres = new string[3];

            nombres[0] = "Juan";
            nombres[1] = "Ana";
            nombres[2] = "Luis";

            Console.WriteLine("Nombre 1: " + nombres[0]);
            Console.WriteLine("Nombre 2: " + nombres[1]);
            Console.WriteLine("Nombre 3: " + nombres[2]);

            Console.ReadLine();

            // Ejercicio4: Notas

            Console.WriteLine("--- EJERCICIO: NOTAS ---");

            int[] notas = new int[3];

            notas[0] = 7;
            notas[1] = 9;
            notas[2] = 6;

            Console.WriteLine("Nota 1: " + notas[0]);
            Console.WriteLine("Nota 2: " + notas[1]);
            Console.WriteLine("Nota 3: " + notas[2]);

            Console.ReadLine();

            // Ejercicio5: Ciudades
            Console.WriteLine("--- EJERCICIO: CIUDADES ---");

            string[] ciudades = new string[3];

            ciudades[0] = "Buenos Aires";
            ciudades[1] = "Córdoba";
            ciudades[2] = "Rosario";

            Console.WriteLine("Ciudad 1: " + ciudades[0]);
            Console.WriteLine("Ciudad 2: " + ciudades[1]);
            Console.WriteLine("Ciudad 3: " + ciudades[2]);
            
            Console.ReadLine();

        }
    }
}