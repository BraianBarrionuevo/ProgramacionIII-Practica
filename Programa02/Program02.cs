﻿namespace Programa02;

class Program02
{
    static void Main(string[] args)
    {
            Console.WriteLine("**** Datos de Alumno ****");

           string nombre = "Braian Barrionuevo";
            int edad = 28;
            int legajo = 63598;
            string comision = "Comision 8 - TUP";
            string profe = "Rodrigo Esper";

            Console.WriteLine("Nombre: "+ nombre);
            Console.WriteLine("   Para números sin decimales, como edad o cantidad.");
            Console.WriteLine("   Edad: " + edad);
            Console.WriteLine("   Legajo: " + legajo);
            Console.WriteLine("   "+comision);
            Console.WriteLine("   Profe: "+profe);

            Console.WriteLine("\n****************************");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            //Ejercicio 2
             Console.WriteLine("--- BLOQUE 1: PRODUCTOS ---");

        int cantidadProductos = 15;

        Console.WriteLine("1. TIPO ENTERO (int):");
        Console.WriteLine("   Para cantidades sin decimales, como stock o unidades.");
        Console.WriteLine("   Valor guardado: " + cantidadProductos);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
        
            //Ejercicio 3

            Console.WriteLine("--- BLOQUE 1: ALUMNOS ---");

        int alumnos = 30;

        Console.WriteLine("1. TIPO ENTERO (int):");
        Console.WriteLine("   Para contar personas sin decimales.");
        Console.WriteLine("   Valor guardado: " + alumnos);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
        //Ejercicio 4

        Console.WriteLine("--- BLOQUE 1: KILÓMETROS ---");

        int kilometros = 120;

        Console.WriteLine("1. TIPO ENTERO (int):");
        Console.WriteLine("   Para medir distancias sin decimales.");
        Console.WriteLine("   Valor guardado: " + kilometros);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

        //Ejercicio 5
        Console.WriteLine("--- BLOQUE 1: PUNTAJE ---");

        int puntos = 850;

        Console.WriteLine("1. TIPO ENTERO (int):");
        Console.WriteLine("   Para representar puntajes sin decimales.");
        Console.WriteLine("   Valor guardado: " + puntos);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}
