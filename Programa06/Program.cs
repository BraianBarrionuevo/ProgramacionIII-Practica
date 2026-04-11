﻿namespace Programa06;

class Program
{
    static void Main(string[] args)
    {
       //Ejercicio 1 ---------------------------------------
        Console.WriteLine("--- BLOQUE 5: GIMNASIO ---");
        const string NOMBRE_APP = "FitLife Gym";
        const string VERSION = "v2.1.0";
        const int EDAD_MINIMA = 16;

        Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
        Console.WriteLine("Cargando reglas del sistema...");
        Console.WriteLine("Restricción: Solo mayores de " + EDAD_MINIMA + " años.");

        const int EDAD_CLIENTE = 18;
        const bool PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMA;

        Console.WriteLine("\nVerificando cliente de " + EDAD_CLIENTE + " años...");
        Console.WriteLine("Edad mínima: " + EDAD_MINIMA);
        Console.WriteLine("Acceso permitido (valor bool constante): " + PUEDE_INGRESAR);

        Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
        Console.WriteLine("Constante VERSION = " + VERSION);

        Console.ReadLine();

            //Ejercicio 2 --------------------------------------
        Console.WriteLine("--- BLOQUE 5: EDUCACIÓN ---");
            const string NOMBRE_APP = "EduControl";
        const string VERSION = "v3.0.0";
        const int NOTA_MINIMA = 6;

        Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
        Console.WriteLine("Cargando reglas del sistema...");
        Console.WriteLine("Restricción: Nota mínima para aprobar: " + NOTA_MINIMA);

        const int NOTA_ALUMNO = 7;
        const bool APROBADO = NOTA_ALUMNO >= NOTA_MINIMA;

        Console.WriteLine("\nVerificando nota del alumno: " + NOTA_ALUMNO);
        Console.WriteLine("Nota mínima: " + NOTA_MINIMA);
        Console.WriteLine("¿Aprobado?: " + APROBADO);

        Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
        Console.WriteLine("Constante VERSION = " + VERSION);

        Console.ReadLine();

             //Ejercicio 3 --------------------------------------
        Console.WriteLine("--- BLOQUE 5: VEHÍCULO ---");
            const string NOMBRE_APP = "RentCar Plus";
        const string VERSION = "v1.5.3";
        const int EDAD_MINIMA = 21;

        Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
        Console.WriteLine("Cargando reglas del sistema...");
        Console.WriteLine("Restricción: Edad mínima para alquilar: " + EDAD_MINIMA);

        const int EDAD_CLIENTE = 19;
        const bool PUEDE_ALQUILAR = EDAD_CLIENTE >= EDAD_MINIMA;

        Console.WriteLine("\nVerificando cliente de " + EDAD_CLIENTE + " años...");
        Console.WriteLine("Edad mínima: " + EDAD_MINIMA);
        Console.WriteLine("¿Puede alquilar?: " + PUEDE_ALQUILAR);

        Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
        Console.WriteLine("Constante VERSION = " + VERSION);

        Console.ReadLine();
        
             //Ejercicio 4 --------------------------------------
        Console.WriteLine("--- BLOQUE 5: RESTAURANTE ---");
              const string NOMBRE_APP = "FoodExpress";
        const string VERSION = "v4.2.1";
        const int MONTO_MINIMO = 3000;

        Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
        Console.WriteLine("Cargando reglas del sistema...");
        Console.WriteLine("Restricción: Pedido mínimo de $" + MONTO_MINIMO);

        const int MONTO_CLIENTE = 3500;
        const bool PEDIDO_VALIDO = MONTO_CLIENTE >= MONTO_MINIMO;

        Console.WriteLine("\nVerificando pedido de $" + MONTO_CLIENTE + "...");
        Console.WriteLine("Monto mínimo: $" + MONTO_MINIMO);
        Console.WriteLine("¿Pedido válido?: " + PEDIDO_VALIDO);

        Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
        Console.WriteLine("Constante VERSION = " + VERSION);

        Console.ReadLine();
        
             //Ejercicio 5 --------------------------------------
        Console.WriteLine("--- BLOQUE 5: VIDEOJUEGOS ---");
             const string NOMBRE_APP = "BattleZone";
        const string VERSION = "v5.0.0";
        const int NIVEL_MINIMO = 10;

        Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
        Console.WriteLine("Cargando reglas del sistema...");
        Console.WriteLine("Restricción: Nivel mínimo requerido: " + NIVEL_MINIMO);

        const int NIVEL_JUGADOR = 12;
        const bool PUEDE_JUGAR = NIVEL_JUGADOR >= NIVEL_MINIMO;

        Console.WriteLine("\nVerificando jugador con nivel " + NIVEL_JUGADOR + "...");
        Console.WriteLine("Nivel mínimo: " + NIVEL_MINIMO);
        Console.WriteLine("¿Puede acceder?: " + PUEDE_JUGAR);

        Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
        Console.WriteLine("Constante VERSION = " + VERSION);

        Console.ReadLine();
    }
}
