namespace Programa01;

class Programa
{
    static void Main(string[] args)
    {
           Console.WriteLine("--- SISTEMA DE REGISTRO DE USUARIO ---");

            
            Console.Write("Por favor, ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Por favor, ingrese su apellido: ");
            string apellido = Console.ReadLine();

            
            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            
            Console.Write("Ingresa tu estatura (ejemplo: 1,75): ");
            double estatura = double.Parse(Console.ReadLine()); 
            
            Console.Write("Ingrese el nombre de su equipo favorito: ");
            string equipo = Console.ReadLine();

            Console.Write("Ingrese el nombre de su mascota: ");
            string mascota = Console.ReadLine();

            
            Console.WriteLine("\n--- PERFIL CREADO ---");
            Console.WriteLine("Nombre: " + nombre);
             Console.WriteLine("Nombre: " + apellido);
            Console.WriteLine("Edad el próximo año: " + (edad + 1)); 
            Console.WriteLine("Estatura: " + estatura + " metros");
            Console.WriteLine("Equipo Favorito: " + equipo);
             Console.WriteLine("Mascota " + mascota);
            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadKey();
    }
}