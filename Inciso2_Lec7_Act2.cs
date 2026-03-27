internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Determinar nota");
        Console.WriteLine("ingrese la nota");
        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota >= 0 && nota < 60) {
            Console.WriteLine("deficiente");
        }
        if (nota >= 60 && nota < 70)
        {
            Console.WriteLine("Regular");
        }
        if (nota >= 70 && nota < 80)
        {
            Console.WriteLine("Bien");
        }
        if (nota >= 80 && nota < 90)
        {
            Console.WriteLine("Muy bien");
        }
        if (nota >= 90 && nota < 100)
        {
            Console.WriteLine("Exelente");
        }
    }
}
