internal class Program
{
    private static void Main(string[] args)
    {
        int num, suma;

        Console.WriteLine("Ingrese un numero:");
        num = Convert.ToInt32(Console.ReadLine());

        suma = 0;

        Console.WriteLine();
        Console.WriteLine("Cuenta regresiva:");
        Console.WriteLine();

        while (num >= 1)
        {
            Console.WriteLine(num);

            suma = suma + num;

            num = num - 1;
        }

        Console.WriteLine();
        Console.WriteLine("La suma total es: " + suma);

        Console.ReadKey();
    }
}