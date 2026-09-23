namespace Namngenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Du ska simulera ett tärningskast.
            //Instruktioner:
            //Använd klassen Random(inbyggd i C#) för att skapa ett slumptal mellan 1 och 6.
            Random Rnd = new Random();
            int tarning = Rnd.Next(1, 7); //Genererar ett slumptal mellan 1 och 6.
            //Skriv ut resultatet på skärmen.
            //Extra: Låt programmet kasta två tärningar och skriv ut summan.
            Console.WriteLine($"Tärning 1: {tarning}");
            int tarning2 = Rnd.Next(1, 7);
            Console.WriteLine($"Tärning 2: {tarning2}");
            Console.WriteLine($"Summa: {tarning + tarning2}");

        }
    }
}
