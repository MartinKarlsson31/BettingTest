namespace Betting
{
    internal class Program
    {
        static void Main(string[] args)
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

            //lägga till fler funktioner och regler efter behov för att göra spelet mer avancerat och intressant.
            // 18års gräns
            // kunna sätta in pengar och göra så det dras ex 50kr vid varje gissning
            // göra en meny
            // Gömd skatt/bonus
            // skapa medveta fel
        }
    }
}