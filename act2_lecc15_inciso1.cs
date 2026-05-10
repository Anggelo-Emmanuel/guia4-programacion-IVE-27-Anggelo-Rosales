internal class act2_lecc15_inciso1
{
    private static void Main(string[] args)
    {
        int num, i, contador, cantidadPrimos, sumaPrimos;

        cantidadPrimos = 0;
        sumaPrimos = 0;

        for (num = 1; num <= 100; num++)
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
                cantidadPrimos = cantidadPrimos + 1;

                sumaPrimos = sumaPrimos + num;

                if (num < 97)
                {
                    Console.Write(num + " + ");
                }
                else
                {
                    Console.Write(num);
                }
            }
        }

        Console.WriteLine(" = " + sumaPrimos);

        Console.WriteLine("Cantidad de numeros primos: " + cantidadPrimos);

        Console.ReadKey();
    }
}