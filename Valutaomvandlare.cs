using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting
{
    internal class Valutaomvandlare
    {        
        public static void Main(string[] args)
        {
            Valutaomvandlare valutaomvandlare = new Valutaomvandlare();
            valutaomvandlare.CurrencyConverter();
        }

        private void CurrencyConverter()
        {
            Console.WriteLine("Valutaomvandlare");
            Console.WriteLine("1. SEK till EUR");
            Console.WriteLine("2. EUR till SEK");
            Console.WriteLine("3. Tillbaka till huvudmenyn");
            Console.Write("Välj alternativ: ");

            int conversionChoice = InputNr(); 
            Console.Clear();

            switch (conversionChoice)
            {
                case 1:
                    Console.Write("Ange belopp i SEK: ");
                    double sekAmount = InputDouble(); 
                    double eurAmount = ConvertSekToEur(sekAmount);
                    Console.WriteLine($"{sekAmount} SEK är ungefär {eurAmount} EUR.");
                    break;
                case 2:
                    Console.Write("Ange belopp i EUR: ");
                    double eurAmount2 = InputDouble();
                    double sekAmount2 = ConvertEurToSek(eurAmount2);
                    Console.WriteLine($"{eurAmount2} EUR är ungefär {sekAmount2} SEK.");
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }

        private double ConvertSekToEur(double sekAmount)
        {            
            double exchangeRate = 0.12; 
            double eurAmount = sekAmount * exchangeRate;
            return eurAmount;
        }

        private double ConvertEurToSek(double eurAmount)
        {            
            double exchangeRate = 14.0; 
            double sekAmount = eurAmount * exchangeRate;
            return sekAmount;
        }
               
        private int InputNr()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Ogiltig inmatning. Ange ett heltal.");
            }
            return result;
        }

        private double InputDouble()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Ogiltig inmatning. Ange ett numeriskt värde.");
            }
            return result;
        }
    }
}

