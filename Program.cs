namespace Namngenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Skriva ett program(Console App)
        //som frågar användare att först skriva in 2 tal i terminalen, för att
        //programet ska addera de och skriva
        //ut resultatet i terminal
        Console.WriteLine("Skriv in första talet: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in andra talet: ");
            int tal2 = int.Parse(Console.ReadLine());
            int summa = tal1 + tal2;
            Console.WriteLine($"Summan av {tal1} och {tal2} är {summa}");
        }
    }
}
