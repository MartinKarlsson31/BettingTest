namespace Betting
{
    internal partial class MyBetting
    {

        public void start()
        {
            while (true)
            {
                // testing
                Console.WriteLine("Välkommen till Casono Avengers, välj ett av alternativen");
                Console.WriteLine("1. Spela gissa numret");
                Console.WriteLine("2. Sätt in pengar");
                Console.WriteLine("3. Spela Sten, Sax, Påse");
                Console.WriteLine("4. Logga ut");
                Console.Write("Knappa in ditt val : ");

                int input = inputNr();
                Console.Clear();

                switch (input)
                {
                    case 1:
                        Guessnr();
                        break;
                    case 2:
                        Deposit();
                        break;
                    case 3:
                        RockPaperScissors game = new RockPaperScissors();
                        game.PlayRPS(); ;
                        break;
                }
            }
        }

        private int inputNr()
        {
            int nr;
            while (!int.TryParse(Console.ReadLine(), out nr))
            {
                Console.WriteLine("inmatnings fel");
            }

            return nr;
        }
    }
}