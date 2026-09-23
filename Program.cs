namespace Namngenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uppgift 3 – Pizzakalkylatorn
            //Du ska räkna ut priset på pizzor med moms.
            //Instruktioner:
            //Skapa en const som heter MOMS och sätt den till 0.12(12 %).
            const double MOMS = 0.12;
            //Be användaren skriva in antal pizzor.
            Console.WriteLine("Ange antal pizzor: ");
            int antalPizzor = int.Parse(Console.ReadLine());
            //Be användaren skriva in pris per pizza.
            Console.WriteLine("Ange pris per pizza: ");
            double prisPerPizza = double.Parse(Console.ReadLine());
            //Räkna ut:
            //Totalsumma utan moms
            String totalsummaUtanMoms = (antalPizzor * prisPerPizza).ToString();
            Console.WriteLine("Totalsumma utan moms: " + totalsummaUtanMoms);
            //Momsbelopp
            String momsbelopp = (antalPizzor * prisPerPizza * MOMS).ToString();
            Console.WriteLine("Momsbelopp: " + momsbelopp);
            //Totalsumma med moms
            String totalsummaMedMoms = (antalPizzor * prisPerPizza + double.Parse(momsbelopp)).ToString();
            Console.WriteLine("Totalsumma med moms: " + totalsummaMedMoms);
            //Skriv ut alla tre resultaten på skärmen.
            //Tips:
            //Använd Convert.ToInt32() eller Convert.ToDouble() för att konvertera input.

        }
    }
}
