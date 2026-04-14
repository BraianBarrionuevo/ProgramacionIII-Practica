using System;
namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1: Precios
            Console.WriteLine("--- EJERCICIO: PRECIOS ---");

            double[] precios = { 1500.5, 2300.75, 999.99, 450.0, 1200.25 };

            int cantidad = precios.Length;
            Console.WriteLine("El arreglo tiene " + cantidad + " elementos");
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < precios.Length; i++)
            {
                Console.WriteLine("Índice " + i + ": Precio = " + precios[i]);
            }

            Console.ReadLine();

            //Ejercicio2: Nombres
            Console.WriteLine("--- EJERCICIO: NOMBRES ---");

            string[] nombres = { "Juan", "Ana", "Luis", "Sofía", "Pedro" };

            int cantidad1 = nombres.Length;
            Console.WriteLine("El arreglo tiene " + cantidad1 + " elementos");
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Índice " + i + ": Nombre = " + nombres[i]);
            }

            Console.ReadLine();

            //Ejercicio3: Temperaturas
            Console.WriteLine("--- EJERCICIO: TEMPERATURAS ---");

            double[] temperaturas = { 22.5, 18.3, 30.0, 15.8, 27.2 };

            int cantidad2 = temperaturas.Length;
            Console.WriteLine("El arreglo tiene " + cantidad2 + " elementos");
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.WriteLine("Índice " + i + ": Temp = " + temperaturas[i]);
            }

            Console.ReadLine();


            //Ejercicio4: Notas
            Console.WriteLine("--- EJERCICIO: NOTAS ---");

            int[] notas = { 7, 9, 6, 8, 10 };

            int cantidad3 = notas.Length;
            Console.WriteLine("El arreglo tiene " + cantidad3 + " elementos");
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Índice " + i + ": Nota = " + notas[i]);
            }

            Console.ReadLine();

            //Ejercicio5: Productos

            Console.WriteLine("--- EJERCICIO: PRODUCTOS ---");

            string[] productos = { "Pan", "Leche", "Queso", "Huevos", "Arroz" };

            int cantidad4 = productos.Length;
            Console.WriteLine("El arreglo tiene " + cantidad4 + " elementos");
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine("Índice " + i + ": Producto = " + productos[i]);
            }

            Console.ReadLine();
        }
    }
}