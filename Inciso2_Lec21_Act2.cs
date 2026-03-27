internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===Buzon de voz===");
        Console.WriteLine("MENU PRINCIPAL");
        Console.WriteLine("Ingrese el mensaje de voz:");
        int opcion;
        Console.WriteLine("1-Ventas");
        Console.WriteLine("2-Recepción");
        Console.WriteLine("3-Dirección");
        Console.WriteLine("4-Compras");
        Console.WriteLine("digite la opcion que desea: ");
        opcion = Convert.ToInt32(Console.ReadLine());

        if(opcion == 1)
        {
            Console.Clear();

            Console.WriteLine("Bienvenido al depto de Ventas");
            Console.WriteLine("VentasOrg@gmail.com");
        }
        if (opcion == 2)
        {
            Console.Clear();

            Console.WriteLine("Bienvenido al depto de Recepción");
            Console.WriteLine("Recepción@gmail.com");
        }
        if (opcion == 3)
        {
            Console.Clear();

            Console.WriteLine("Bienvenido al depto de Dirección");
            Console.WriteLine("Dirección@gmail.com");
        }
        if (opcion == 4)
        {
            Console.Clear();

            Console.WriteLine("Bienvenido al depto de 4-Compras");
            Console.WriteLine("4-Compras@gmail.com");
        }
        if (opcion != 1 && opcion != 2 && opcion != 3 && opcion != 4 )
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