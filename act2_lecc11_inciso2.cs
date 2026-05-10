internal class Program
{
    private static void Main(string[] args)
    {
        int i;

        i = 1;

        while (i <= 100)
        {
            Console.WriteLine(i);

            i = i + 2;
        }

        Console.ReadKey();
    }
}