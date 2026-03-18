internal class Program
{
    private static void Main(string[] args)
    {   //entrada
        Console.WriteLine("Ingrese un numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        //salida
        Console.WriteLine("Numeros positivos y negativos!");
        if (numero >= 0) {
            Console.WriteLine("El numero es positivo");
        }
        else
        {
            Console.WriteLine("El numero es negativo");
        }

    }
}