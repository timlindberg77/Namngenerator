namespace Namngenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hejsan skriv ditt förnamn:");
            string namn = Console.ReadLine();

            Console.WriteLine("Skriv in din favoritfärg:");
            string färg = Console.ReadLine();

            Console.WriteLine($"Ditt roliga namn är: Big {namn} av {färg} Tokyo");
        }
    }
}
