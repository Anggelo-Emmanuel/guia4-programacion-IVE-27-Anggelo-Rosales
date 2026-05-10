internal class act3_lecc15_inciso2
{
    private static void Main(string[] args)
    {
        int num, i, contador, primos, sumaPares;

        primos = 0;
        sumaPares = 0;

        num = 300;

        Console.WriteLine("Suma de numeros pares:");
        Console.WriteLine();

        while (num >= 1)
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
                primos = primos + 1;
            }

            if (num % 2 == 0)
            {
                sumaPares = sumaPares + num;

                if (num > 2)
                {
                    Console.Write(num + " + ");
                }
                else
                {
                    Console.Write(num);
                }
            }

            num = num - 1;
        }

        Console.WriteLine(" = " + sumaPares);

        Console.WriteLine();
        Console.WriteLine("Cantidad de numeros primos: " + primos);

        Console.ReadKey();
    }
}