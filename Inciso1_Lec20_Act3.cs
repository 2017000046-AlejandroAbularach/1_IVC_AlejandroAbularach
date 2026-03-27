using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese un número del 1 al 7: ");
        int dia = int.Parse(Console.ReadLine());

        if (dia <= 5) {
            Console.WriteLine("Entre semana");
        }
        else if (dia >= 6) {
            Console.WriteLine("Fin de semana");
        
        }
    }
}