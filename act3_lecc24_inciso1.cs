internal class Program
{
    private static void Main(string[] args)
    {
        int num, i, contador, suma;

        suma = 0;

        Console.WriteLine("Numeros primos entre 1 y 50:");
        Console.WriteLine();

        for (num = 1; num <= 50; num++)
        {
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
                suma = suma + num;

                if (num < 47)
                {
                    Console.Write(num + " + ");
                }
                else
                {
                    Console.Write(num);
                }
            }
        }

        Console.WriteLine(" = " + suma);

        Console.ReadKey();
    }
}