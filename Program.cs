using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LIquid_Rechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double liquidmänge = 0;
                double aromaMenge = 0;
                double gewünschteNikotinStärke = 0;
                double nikotinShotStärke = 0;

                try
                {
                    Console.Write("Menge des Liquids (Flaschenkapatzität) in ml: ");
                    liquidmänge = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Aroma Anteil in %: ");
                    aromaMenge = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Gewünschte Nikotinstärke in mg: ");
                    gewünschteNikotinStärke = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nikotinstärke der Shots mg/ml: ");
                    nikotinShotStärke = Convert.ToDouble(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("nur zahlen sind erlaubt!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                double aromaKonzentrationInML = liquidmänge / 100 * aromaMenge;

                double nikotinProzentInLiquid = (100 / nikotinShotStärke) * gewünschteNikotinStärke;
                double nikotinUmgerrechnetInML = (liquidmänge / 100) * nikotinProzentInLiquid;

                double restBaseMenge = liquidmänge - aromaKonzentrationInML - nikotinUmgerrechnetInML;


                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(restBaseMenge + ": ml Base Liquid.");
                Console.WriteLine(aromaKonzentrationInML + ": ml Aroma.");
                Console.WriteLine(nikotinUmgerrechnetInML + ": ml Nikotinshot´s.");
                Console.ResetColor();

                Console.ReadKey();
                Console.Clear();

            }
        }

    }
}
