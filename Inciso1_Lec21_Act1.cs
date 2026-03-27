using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese un número (1-7): ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 1) {
            Console.WriteLine("Hoy es lunes");
        }
        else if (num == 2) {
            Console.WriteLine("Hoy es martes");
        }
        else if (num == 3) {
            Console.WriteLine("Hoy es miércoles");
        }
        else if (num == 4) {
            Console.WriteLine("Hoy es jueves");
        }
        else if (num == 5) {
            Console.WriteLine("Hoy es viernes");
        }
        else if (num == 6) {
            Console.WriteLine("Hoy es sábado");
        }
        else if (num == 7) {
            Console.WriteLine("Hoy es domingo");
        }
        else {
            Console.WriteLine("El número ingresado no es válido.");
        }
    }
}