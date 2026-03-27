using System;

internal class Program
{
    private static void Main(string[] args)
    {

        string passwordCorrecta = "Password123";

        Console.WriteLine("SISTEMA DE SEGURIDAD");
        Console.Write("Ingrese su contraseña: ");
        
        
        string intento = Console.ReadLine();

        
        if (intento == passwordCorrecta)
        {
            Console.WriteLine("Bienvenida. Acceso concedido.");
        }
        else
        {
            Console.WriteLine("Ingreso prohibido. Contraseña incorrecta.");
        }

    }
}