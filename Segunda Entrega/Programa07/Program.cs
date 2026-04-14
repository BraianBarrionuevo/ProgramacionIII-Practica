﻿namespace Programa07;

class Program
{
    static void Main(string[] args)
    {
        //Ejercicio 1 ---------------------------------------
        Console.WriteLine("--- BLOQUE 6: DESCUENTOS ---");
        const decimal DESCUENTO = 0.10m; // 10%
        const bool MODO_PRUEBA = false;
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- MÓDULO DE DESCUENTOS ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal precioBase = 2000.00m;
        decimal descuentoAplicado = precioBase * DESCUENTO;
        decimal total = precioBase - descuentoAplicado;

        Console.WriteLine("\nDetalle de la compra:");
        Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
        Console.WriteLine("Descuento (" + (DESCUENTO * 100) + "%): -" + SIMBOLO_PESO + descuentoAplicado);
        Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

        Console.ReadLine();


            //Ejercicio 2 --------------------------------------
        Console.WriteLine("--- BLOQUE 6: Gimnasio ---");
            const decimal RECARGO = 0.15m; // 15%
        const bool MODO_PRUEBA = false;
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- MÓDULO DE CUOTAS ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal cuotaBase = 8000.00m;
        decimal recargo = cuotaBase * RECARGO;
        decimal total = cuotaBase + recargo;

        Console.WriteLine("\nDetalle de la cuota:");
        Console.WriteLine("Cuota base: " + SIMBOLO_PESO + cuotaBase);
        Console.WriteLine("Recargo (" + (RECARGO * 100) + "%): " + SIMBOLO_PESO + recargo);
        Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

        Console.ReadLine();

        //Ejercicio 3 --------------------------------------
        Console.WriteLine("--- BLOQUE 6: Combustible ---");
        const decimal IMPUESTO = 0.18m; // 18%
        const bool MODO_PRUEBA = false;
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- MÓDULO DE COMBUSTIBLE ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal precioCombustible = 1200.00m;
        decimal impuesto = precioCombustible * IMPUESTO;
        decimal total = precioCombustible + impuesto;

        Console.WriteLine("\nDetalle de carga:");
        Console.WriteLine("Precio base: " + SIMBOLO_PESO + precioCombustible);
        Console.WriteLine("Impuesto (" + (IMPUESTO * 100) + "%): " + SIMBOLO_PESO + impuesto);
        Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

        Console.ReadLine();

        //Ejercicio 4 --------------------------------------
        const decimal BECA = 0.25m; // 25%
        const bool MODO_PRUEBA = false;
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- MÓDULO DE INSCRIPCIÓN ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal cuota = 10000.00m;
        decimal descuentoBeca = cuota * BECA;
        decimal total = cuota - descuentoBeca;

        Console.WriteLine("\nDetalle de inscripción:");
        Console.WriteLine("Cuota: " + SIMBOLO_PESO + cuota);
        Console.WriteLine("Beca (" + (BECA * 100) + "%): -" + SIMBOLO_PESO + descuentoBeca);
        Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

        Console.ReadLine();

            //Ejercicio 5 --------------------------------------
        Console.WriteLine("--- BLOQUE 6: Restaurante ---");
            const decimal PROPINA = 0.12m; // 12%
        const bool MODO_PRUEBA = false;
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- MÓDULO DE RESTAURANTE ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal consumo = 5000.00m;
        decimal propina = consumo * PROPINA;
        decimal total = consumo + propina;

        Console.WriteLine("\nDetalle de la cuenta:");
        Console.WriteLine("Consumo: " + SIMBOLO_PESO + consumo);
        Console.WriteLine("Propina (" + (PROPINA * 100) + "%): " + SIMBOLO_PESO + propina);
        Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

        Console.ReadLine();
    }
}