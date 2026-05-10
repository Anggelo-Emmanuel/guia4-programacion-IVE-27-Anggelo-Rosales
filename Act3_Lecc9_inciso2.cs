internal class Program
{
    private static void Main(string[] args)
    {
        int num, i, contador;

        Console.WriteLine("Ingrese un numero:");
        num = Convert.ToInt32(Console.ReadLine());

        contador = 0;

        for (i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                contador = contador + 1;
            }
        }

        if (contador == 2)
        {
            Console.WriteLine("Es numero primo");
        }
        else
        {
            Console.WriteLine("No es numero primo");
        }

        Console.ReadKey();
    }
}