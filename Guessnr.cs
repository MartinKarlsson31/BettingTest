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
            Random random = new Random();
            int minNumber = 1;
            int maxNumber = 10;
            int randomNumber = random.Next(minNumber, maxNumber + 1);

            Console.WriteLine("Välkommen till Bettingspelet!");
            Console.WriteLine($"Jag har valt ett slumpmässigt nummer mellan {minNumber} och {maxNumber}.");
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

            //Sätta 18 års gräns ?

        }
    }
   
}
