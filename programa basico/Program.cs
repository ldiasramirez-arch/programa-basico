using System;

class Program
{
    static void Main()
    {
        
        Console.Clear();
        Console.WriteLine("--- REGISTRO DE USUARIO ---");

      
        Console.Write("Introduce tu nombre: ");
        string nombre = Console.ReadLine()!;

      
        Console.Write("Introduce tu apellido: ");
        string apellido = Console.ReadLine()!;

      
        Console.Write("Introduce tu edad: ");
        int edad;
        while (!int.TryParse(Console.ReadLine(), out edad))
        {
            Console.Write("Error. Por favor, introduce un número válido para la edad: ");
        }

       
        Console.Write("Introduce tu altura:");
        double altura;
        while (!double.TryParse(Console.ReadLine(), out altura))
        {
            Console.Write("Error. Introduce una altura válida (ej: 1,75 o 1.75): ");
        }

        Console.WriteLine($"Hola, mi nombre es {nombre} {apellido}.");
        Console.WriteLine($"Tengo {edad} años y mi altura es de {altura} metros.");
        
        Console.WriteLine("\nPresiona cualquier tecla para finalizar...");
        Console.ReadKey();
    }
}


