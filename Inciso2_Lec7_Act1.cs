internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calcular edad mayor o menor de edad");
        int edad;
        Console.WriteLine("Dime tu edad: ");
        edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad");
        }
        else
        {
            Console.WriteLine("Eres menor de edad");
        }

    }
}
