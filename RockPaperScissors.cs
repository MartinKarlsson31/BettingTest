using System;

namespace Betting
{
    public class RockPaperScissors
    {
        public void PlayRPS()
        {
            Console.WriteLine("Welcome to a game of Rock, Paper, Scissors!");

            while (true)
            {
                Console.WriteLine("Enter your choice (1 for rock, 2 for paper, or 3 for scissors): ");
                int playerChoice = int.Parse(Console.ReadLine());

                // Computer generates a random choice
                Random random = new Random();
                int computerChoice = random.Next(1, 4);

                string computerChoiceStr = "";
                switch (computerChoice)
                {
                    case 1:
                        computerChoiceStr = "rock";
                        break;
                    case 2:
                        computerChoiceStr = "paper";
                        break;
                    case 3:
                        computerChoiceStr = "scissors";
                        break;
                }
                Console.WriteLine($"Computer chose: {computerChoiceStr}");

                // Determine the winner
                string result = "";
                if (playerChoice == computerChoice)
                {
                    result = "\nIt's a tie!";
                }
                else if (
                    (playerChoice == 1 && computerChoice == 3) ||
                    (playerChoice == 2 && computerChoice == 1) ||
                    (playerChoice == 3 && computerChoice == 2)
                )
                {
                    result = "\nYou win!";
                }
                else
                {
                    result = "\nComputer wins!";
                }

                Console.WriteLine(result);

                Console.WriteLine("\nPlay again? (yes/no): ");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain != "yes")
                {
                    break;
                }
            }

            Console.WriteLine("\nThanks for playing!");
        }
    }
}
//TODO Add best of three? 
//TODO Add betting? 
