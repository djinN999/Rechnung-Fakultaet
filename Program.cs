using System;
using System.Collections.Generic;

namespace rechnungfakultaet
{
    class rechnung
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welches der folgenden Programme wollen Sie ausführen wollen.");
            Console.WriteLine("[1] Rechnung");
            Console.WriteLine("[2] Fakultaet");
            int r;
            r = Convert.ToInt32(Console.ReadLine());

            switch (r) 
            {
                case 1:
                    Console.Clear();
                    NewArray();
                    break;
                case 2:
                    Console.Clear();
                    Fakultaet();
                    break;
                default:
                    Console.WriteLine("Bitte wählen sie zwischen 1 und 2");
                    break;
            }

            Console.ReadKey();
        }
        public static void Fakultaet()
        {
            Console.WriteLine("Geben Sie die Zahl ein, für die eine Fakultaet berechnet wertden soll.");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.Write("Berechnung: {0}", i);

            Ulong fakultaet;
            fakultaet = Convert.ToUInt64(i);
            
            int original = i; 
           
            while (i > 1)
            {
                Console.Write(" * {0}", --i); 
                fakultaet *= Convert.ToUInt64(i);
            }
            Console.WriteLine("");
            Console.WriteLine("Die Fakultät von {0} lautet {1}.", original, fakultaet);

            Console.ReadKey();
        }
        public static void NewArray()
        {
            List<int> listAmount = new List<int>();
            List<double> listPrice = new List<double>();
            double mwst;
            double bruttoPrice;
            double amount;
            double singlePrice;
            double nettoPrice;
            double nettoSum = 0;

            do
            {
                Console.Write("Bitte geben Sie die Artikelmenge ein (0 = Ende): ");
                amount = Convert.ToDouble(Console.ReadLine());
                if (amount == 0) break;

                Console.Write("Bitte Einzelpreis eingeben: ");
                singlePrice = Convert.ToDouble(Console.ReadLine());

                nettoPrice = amount * singlePrice;

                nettoSum += nettoPrice;
            }
            while (amount != 0);

            mwst = 0.19 * nettoSum;
            bruttoPrice = nettoSum + mwst;

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Gesamtpreis Netto            {0:F2} Euro", nettoSum);
            Console.WriteLine("+ 19 % Mehrwertsteuer         {0:F2} Euro", mwst);
            Console.WriteLine("============================================");
            Console.WriteLine("Gesamtpreis Brutto           {0:F2} Euro", bruttoPrice);
            Console.WriteLine("--------------------------------------------");
        }
       
    }
}
