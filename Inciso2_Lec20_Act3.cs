using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese la nota final: ");
        double nota = double.Parse(Console.ReadLine());

        if (nota >= 61) {
            Console.WriteLine("Aprobado");
        }
        else {
            Console.WriteLine("Reprobado");
        }
    }
}