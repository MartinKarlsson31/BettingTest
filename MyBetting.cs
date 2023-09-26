namespace Betting
{
    internal partial class MyBetting
    {
        //Hårdkodad inloggning
        private string userName = "admin"; 
        private string password = "tiger123";

        public void start()
        {

            Console.WriteLine("Välkommen till Casono Avengers!");

            if(!Login()) //log-in check
            {
                Console.WriteLine("Felkatiga inloggnignsuppgifter.");
                return;
            }

            while (true)
            {
                // testing
                Console.WriteLine("Välkommen till Casono Avengers, välj ett av alternativen");
                Console.WriteLine("1. Spela gissa numret");
                Console.WriteLine("2. Sätt in pengar");
                Console.WriteLine("3. Spela Sten, Sax, Påse");
                Console.WriteLine("4. Valutaomvandlare");
                Console.WriteLine("5. Logga ut");
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
                    case 4:
                        CurrencyConverter();
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;

                }
            }
        }

        private bool Login() //log-in metoden
        {
            Console.Write("Ange ditt användarnamn: ");
            string inputUsername = Console.ReadLine();
            Console.Write("Ange ditt lösenord: ");
            string inputPassword = Console.ReadLine();

            return inputUsername == userName && inputPassword == password;
        }

        //private void Valutaomvandlare()
        //{
        //    throw new NotImplementedException();
        //}

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