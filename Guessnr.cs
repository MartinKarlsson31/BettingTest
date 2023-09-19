using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting
{
    internal partial class MyBetting
    {
        public void Guessnr()
        {
            bool again = false;

            while (again = true)
            {
                Random random = new Random();
                int minNumber = 1;
                int maxNumber = 11;
                int randomNumber = random.Next(minNumber, maxNumber);

                Console.WriteLine("Välkommen till Bettingspelet!");
                Console.WriteLine($"Jag har valt ett slumpmässigt nummer mellan {minNumber} och {maxNumber}.");
                Console.WriteLine("");
                Console.Write("Gissa vilket nummer det är: ");

                int playerGuess;
                if (int.TryParse(Console.ReadLine(), out playerGuess))
                {
                    if (playerGuess >= minNumber && playerGuess <= maxNumber)
                    {
                        if (playerGuess == randomNumber)
                        {
                            Console.WriteLine("Grattis! Du har gissat rätt nummer och vunnit spelet!");
                        }
                        else
                        {
                            Console.WriteLine($"Tyvärr, det slumpmässiga numret var {randomNumber}. Du förlorade.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Din gissning måste vara mellan {minNumber} och {maxNumber}.");
                    }
                }
                else
                {
                    Console.WriteLine("Ogiltig inmatning. Var god ange ett heltal.");
                }

                Console.WriteLine("");
                Console.WriteLine("Vill du spela igen J/N");
                string input = Console.ReadLine().ToLower();

                if (input == "j")
                {
                    Console.Clear();
                }
                else if (input == "n")
                {

                    again = false;
                    Console.Clear();
                    break;
                }
                else if (input != "j" || input != "n")
                {
                    Console.WriteLine("Du valde att trycka galet, så nu tvingar jag dig att spela igen");
                    Console.WriteLine("Tryck enter för att fortsätta");
                    Console.ReadLine();
                    Console.Clear();
                }
                
            }
            

        }
    }
   
}
