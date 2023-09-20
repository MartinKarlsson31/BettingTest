using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting
{
    internal partial class MyBetting
    {
        private int gissningsFörsök = 3;
        private int randomNumber;
        private Random random = new Random();

        public void Guessnr()
        {
            bool again = true;

            while (again)
            {
                // Check if saldo is sufficient to continue playing.
                if (saldo < 50)
                {
                    Console.WriteLine("Tyvärr för lite pengar för att kunna spela sätt in mer fattiglapp.");
                    Console.ReadLine(); 
                    break; // Exit the loop.
                }

                if (gissningsFörsök == 3)
                {
                    int minNumber = 1;
                    int maxNumber = 11;
                    randomNumber = random.Next(minNumber, maxNumber);
                }

                Console.WriteLine("Välkommen till Bettingspelet!");
                Console.WriteLine($"Jag har valt ett slumpmässigt nummer mellan 1 och 10. Du har {gissningsFörsök} försök på dig att gissa och varje gissning kostar 50kr");
                Console.WriteLine($"Ditt saldo: {saldo}");
                Console.WriteLine("");

                int correctGuess = -1; // To keep track of correct guesses.
                bool hasGuessedCorrectly = false; // To track if the player has guessed correctly.
                bool insufficientFunds = false; // To track if the game ended due to insufficient funds.

                for (int i = 0; i < gissningsFörsök; i++)
                {
                    // Check if saldo is sufficient to continue playing.
                    if (saldo < 50)
                    {
                        Console.WriteLine("Tyvärr för lite pengar spelet avslutas så skynda sätt in mer pengar!!");
                        insufficientFunds = true;
                        break;
                    }

                    Console.WriteLine($"Gissning {i + 1} av {gissningsFörsök}");
                    Console.Write("Gissa vilket nummer det är: ");
                    int playerGuess;
                    if (int.TryParse(Console.ReadLine(), out playerGuess))
                    {
                        if (playerGuess >= 1 && playerGuess <= 10)
                        {
                            if (playerGuess == randomNumber)
                            {
                                correctGuess = playerGuess; 
                                saldo += 1000;
                                Console.WriteLine($"Grattis! Du har gissat rätt nummer och vunnit 1000kr. SÅ ditt nya saldo är nu: {saldo} kr");
                                hasGuessedCorrectly = true;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Tyvärr fel gissat, gissa igen.");
                                Console.WriteLine($"{randomNumber}");
                                saldo -= 50;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Din gissning måste vara mellan 1 och 10.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ogiltig inmatning. Var god ange ett heltal.");
                    }

                    if (i < gissningsFörsök - 1)
                    {
                        Console.WriteLine($"Du har {gissningsFörsök - i - 1} gissning(ar) kvar.");
                    }
                }

                if (!hasGuessedCorrectly && !insufficientFunds)
                {
                    Console.WriteLine("Spel slut. Du har använt upp dina gissningsförsök.");
                }


                Console.WriteLine($"Ditt saldo är nu: {saldo} kr");
                Console.WriteLine("Vill du spela igen? (J/N)");
                string input = Console.ReadLine().ToLower();

                if (input != "j")
                {
                    break;
                }
                else
                {
                    gissningsFörsök = 3; 
                }
            }
        }
    }
}




