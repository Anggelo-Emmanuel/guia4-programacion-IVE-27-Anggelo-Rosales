internal class Program
{
    private static void Main(string[] args)
    {
        int opcion, totalBoletos, totalDinero;

        totalBoletos = 0;
        totalDinero = 0;

        do
        {
            Console.WriteLine("1. Boleto adulto ($15)");
            Console.WriteLine("2. Boleto niño ($10)");
            Console.WriteLine("3. Salir");

            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                totalBoletos = totalBoletos + 1;
                totalDinero = totalDinero + 15;

                Console.WriteLine("Boleto adulto vendido");
            }
            else
            {
                if (opcion == 2)
                {
                    totalBoletos = totalBoletos + 1;
                    totalDinero = totalDinero + 10;

                    Console.WriteLine("Boleto niño vendido");
                }
            }

            Console.WriteLine("Boletos vendidos: " + totalBoletos);
            Console.WriteLine("Dinero acumulado: $" + totalDinero);

        } while (opcion != 3);

        Console.WriteLine("Venta finalizada");

        Console.ReadKey();
    }
}