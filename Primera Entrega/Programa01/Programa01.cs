namespace Programa01;

class Programa
{
    static void Main(string[] args)
    {
           Console.WriteLine("--- SISTEMA DE COMPRA ---");

        Console.Write("Ingresa el nombre del producto: ");
        string producto = Console.ReadLine();

        Console.Write("Ingresa la cantidad: ");
        string cantidadTexto = Console.ReadLine();
        int cantidad = int.Parse(cantidadTexto);

        Console.Write("Ingresa el precio unitario: ");
        double precio = double.Parse(Console.ReadLine());

        Console.WriteLine("\n--- RESUMEN DE COMPRA ---");
        Console.WriteLine("Producto: " + producto);
        Console.WriteLine("Cantidad total: " + (cantidad + 1));
        Console.WriteLine("Precio: $" + precio);

        Console.WriteLine("\nPresiona ENTER para salir.");
        Console.ReadLine();

        //-----------------------------------------------------------

        Console.WriteLine("--- REGISTRO FITNESS ---");

        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingresa cuántos días entrenas por semana: ");
        string diasTexto = Console.ReadLine();
        int dias = int.Parse(diasTexto);

        Console.Write("Ingresa tu peso (ejemplo: 70,5): ");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("\n--- RESUMEN FITNESS ---");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Días la próxima semana: " + (dias + 1));
        Console.WriteLine("Peso: " + peso + " kg");

        Console.WriteLine("\nPresiona ENTER para salir.");
        Console.ReadLine();

        //-------------------------------------------------------------

        Console.WriteLine("--- INSCRIPCIÓN ESCOLAR ---");

        Console.Write("Ingresa el nombre del alumno: ");
        string alumno = Console.ReadLine();

        Console.Write("Ingresa el grado actual: ");
        string gradoTexto = Console.ReadLine();
        int grado = int.Parse(gradoTexto);

        Console.Write("Ingresa el promedio: ");
        double promedio = double.Parse(Console.ReadLine());

        Console.WriteLine("\n--- DATOS DEL ALUMNO ---");
        Console.WriteLine("Alumno: " + alumno);
        Console.WriteLine("Grado siguiente: " + (grado + 1));
        Console.WriteLine("Promedio: " + promedio);

        Console.WriteLine("\nPresiona ENTER para salir.");
        Console.ReadLine();

        //-------------------------------------------------------------

        Console.WriteLine("--- REGISTRO DE VEHÍCULO ---");

        Console.Write("Ingresa la marca del auto: ");
        string marca = Console.ReadLine();

        Console.Write("Ingresa el año del vehículo: ");
        string anioTexto = Console.ReadLine();
        int anio = int.Parse(anioTexto);

        Console.Write("Ingresa el consumo (km por litro): ");
        double consumo = double.Parse(Console.ReadLine());

        Console.WriteLine("\n--- DATOS DEL VEHÍCULO ---");
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Año próximo: " + (anio + 1));
        Console.WriteLine("Consumo: " + consumo + " km/l");

        Console.WriteLine("\nPresiona ENTER para salir.");
        Console.ReadLine();

        //----------------------------------------------------------------
    }
}