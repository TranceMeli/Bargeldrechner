namespace Bargeldrückrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            string[] geld = { "500 Euroschein", "200 Euroschein", "100 Euroschein", "50 Euroschein", "20 Euroschein", "10 Euroschein", "5 Euroschein", "2 Euro Münze", "1 Euro Münze", "50 Cent Münze", "20 Cent Münze", "10 Cent Münze", "5 Cent Münze", "1 Cent Münze" };
            int[] scheineundmünzen = { 50000, 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            decimal gegeben;

            Console.WriteLine("Gebe den verlangten Betrag ein: ");
            decimal betrag = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Du hast {betrag} eingegeben");

            while (true)
            {
                Console.WriteLine("Geben Sie den zu zahlenden Betrag ein: ");
                gegeben = Convert.ToDecimal(Console.ReadLine());

                if (gegeben > betrag)
                {
                    break;
                }
                else if (gegeben == betrag)
                {
                    Console.WriteLine("Der gegebene Betrag ist passt genau.");
                    return;
                }
                Console.WriteLine("Der Betrag ist zu niedrig"); 
            }
            decimal rueckgeld = gegeben - betrag;
            Console.WriteLine($"Rückgeld: {rueckgeld}:€");

            int rueckgeldinCent = (int)(rueckgeld * 100);
            

            for (int i = 0; i < scheineundmünzen.Length; i++)
            {
                int anzahl = rueckgeldinCent/scheineundmünzen[i];

                if( anzahl > 0)
                {
                    Console.WriteLine($"{anzahl} x {geld[i]}");
                    rueckgeldinCent = rueckgeldinCent % scheineundmünzen[i];
                }
            }
        }
    }
}
