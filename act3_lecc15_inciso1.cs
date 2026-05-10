internal class Program
{
    private static void Main(string[] args)
    {
        int i, multiplo, suma, pares;

        suma = 0;
        pares = 0;
        i = 1;

        Console.WriteLine("Primeros 20 multiplos de 7:");
        Console.WriteLine();

        while (i <= 20)
        {
            multiplo = i * 7;

            suma = suma + multiplo;

            if (multiplo % 2 == 0)
            {
                pares = pares + 1;
            }

            if (i < 20)
            {
                Console.Write(multiplo + " + ");
            }
            else
            {
                Console.Write(multiplo);
            }

            i = i + 1;
        }

        Console.WriteLine(" = " + suma);

        Console.WriteLine();
        Console.WriteLine("Cantidad de multiplos pares: " + pares);

        Console.ReadKey();
    }
}