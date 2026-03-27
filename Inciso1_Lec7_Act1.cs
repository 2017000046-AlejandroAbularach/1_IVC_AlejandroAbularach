internal class program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===Promedio de notas===");
        int n1,n2,n3,n4,n5;
        string Materia;
        Console.WriteLine("Ingrese el nombre de la materia: ");

        Materia = Console.ReadLine(); 
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        n3 = Convert.ToInt32(Console.ReadLine());
        n4 = Convert.ToInt32(Console.ReadLine());
        n5 = Convert.ToInt32(Console.ReadLine());
        double promedio = (n1 + n2 + n3 + n4 + n5) / 5;
        Console.WriteLine("El promedio de la materia " + Materia + " es: " + promedio);
        if (promedio >= 70) {
            Console.WriteLine("aprobaste");
        }
        else (promedio <= 70) {
            Console.WriteLine("perdiste");
        }

    }
}
