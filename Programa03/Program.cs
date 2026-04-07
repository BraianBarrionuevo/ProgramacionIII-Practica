namespace Programa03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== TRABAJANDO CON DECIMALES EN C# ===\n");

        // 🔹 1. DOUBLE (uso general)
        double estatura = 1.75;
        double peso = 70.5;

        Console.WriteLine("1) DOUBLE (uso general)");
        Console.WriteLine($"   Estatura: {estatura} metros");
        Console.WriteLine($"   Peso: {peso} kg");

        // Operaciones
        double imc = peso / (estatura * estatura);
        Console.WriteLine($"   IMC calculado: {imc}");

        Console.WriteLine("\n----------------------------------\n");

        // 🔹 2. PROBLEMA DE PRECISIÓN
        Console.WriteLine("2) Problema de precisión con double:");

        double num1 = 0.1;
        double num2 = 0.2;
        double resultado = num1 + num2;

        Console.WriteLine($"   0.1 + 0.2 = {resultado}"); // 😱 puede dar 0.30000000000000004

        Console.WriteLine("\n----------------------------------\n");

        // 🔹 3. DECIMAL (financiero)
        Console.WriteLine("3) DECIMAL (ideal para dinero)");

        decimal precio = 199.99m;
        decimal descuento = 20.50m;

        Console.WriteLine($"   Precio original: ${precio}");
        Console.WriteLine($"   Descuento: ${descuento}");

        decimal precioFinal = precio - descuento;
        Console.WriteLine($"   Precio final: ${precioFinal}");

        Console.WriteLine("\n----------------------------------\n");

        // 🔹 4. PRECISIÓN CORRECTA CON DECIMAL
        Console.WriteLine("4) Precisión correcta con decimal:");

        decimal d1 = 0.1m;
        decimal d2 = 0.2m;
        decimal sumaDecimal = d1 + d2;

        Console.WriteLine($"   0.1 + 0.2 = {sumaDecimal}"); 

        Console.WriteLine("\n----------------------------------\n");

        // 🔹 5. CONVERSIÓN ENTRE TIPOS
        Console.WriteLine("5) Conversión de tipos:");

        double numeroDouble = 10.5;
        decimal numeroDecimal = (decimal)numeroDouble;

        Console.WriteLine($"   Double: {numeroDouble}");
        Console.WriteLine($"   Convertido a decimal: {numeroDecimal}");

        Console.WriteLine("\n----------------------------------\n");

        // 🔹 6. REDONDEO
        Console.WriteLine("6) Redondeo:");

        decimal monto = 123.45678m;
        decimal redondeado = Math.Round(monto, 2);

        Console.WriteLine($"   Original: {monto}");
        Console.WriteLine($"   Redondeado a 2 decimales: {redondeado}");

        Console.WriteLine("\nPresiona ENTER para salir...");
        Console.ReadLine();
    }
}