using System;
namespace Uppdrag3._16
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur lång är din låt i minuter?");
            string L = Console.ReadLine();
            int m = Convert.ToInt32(L);
            Console.WriteLine("Hur lång är din låt i sekunder?");
            string k = Console.ReadLine();
            int S = Convert.ToInt32(k);
            int M = m * 60;
            if (M + S <= 260 && M + S >= 165)
            {
                Console.WriteLine("Din låt får spelas på radiostationen!");
            }
            else
            {
                Console.WriteLine("Din låt kommer inte att spelas på radiostationen");
            }
        }
    }
}