internal class act2_lecc15_inciso2
{
    private static void Main(string[] args)
    {
        int billete, contador100, suma100, i;

        contador100 = 0;
        suma100 = 0;

        for (i = 1; i <= 10; i++)
        {
            Console.WriteLine("Ingrese el valor del billete (20, 50 o 100):");
            billete = Convert.ToInt32(Console.ReadLine());

            if (billete == 100)
            {
                contador100 = contador100 + 1;

                suma100 = suma100 + billete;

                Console.WriteLine("Billete de 100 encontrado");
            }
        }

        Console.WriteLine("Cantidad de billetes de 100: " + contador100);

        Console.WriteLine("Procedimiento de suma:");

        for (i = 1; i <= contador100; i++)
        {
            if (i < contador100)
            {
                Console.Write("100 + ");
            }
            else
            {
                Console.Write("100");
            }
        }

        Console.WriteLine(" = " + suma100);

        Console.ReadKey();
    }
}