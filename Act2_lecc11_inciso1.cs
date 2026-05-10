internal class Program
{
    private static void Main(string[] args)
    {
        int num, i, factorial;

        Console.WriteLine("Ingrese un numero entero:");
        num = Convert.ToInt32(Console.ReadLine());

        factorial = 1;
        i = 1;

        while (i <= num)
        {
            factorial = factorial * i;

            i = i + 1;
        }

        Console.WriteLine("El factorial es: " + factorial);

        Console.ReadKey();
    }
}