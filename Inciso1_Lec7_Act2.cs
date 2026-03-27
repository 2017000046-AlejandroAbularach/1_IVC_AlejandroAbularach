internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===Mensaje de voz===");
        Console.WriteLine("MENU PRINCIPAL");
        Console.WriteLine("Ingrese el mensaje de voz:");
        int opcion;
        Console.WriteLine("1-recepcion");
        Console.WriteLine("2-Vigilancia");
        Console.WriteLine("3-Mantenimiento");
        Console.WriteLine("4-Salir");
        Console.WriteLine("digite la opcion que desea: ");
        opcion = Convert.ToInt32(Console.ReadLine());

        if(opcion == 1)
        {
            Console.Clear();

            Console.WriteLine("Bienvenido al depto de recepcion");
        }
        if (opcion == 2)
        {
            Console.Clear();

            Console.WriteLine("Bienvenido al depto de Vigilancia");
        }
        if (opcion == 3)
        {
            Console.Clear();

            Console.WriteLine("Bienvenido al depto de Mantenimiento");
        }
        if (opcion != 1 && opcion != 2 && opcion != 3 )
        {
            Console.WriteLine("Saliendo del Sistema");
            Console.Clear();
            Console.WriteLine("Saliendo del sistema");
        }
        Console.WriteLine("Presione cualquier tecla para salir");
        Console.ReadKey();
        Environment.Exit(0);
    }
}
