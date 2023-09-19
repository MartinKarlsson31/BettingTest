namespace Betting
{
    internal partial class MyBetting
    {
 
        public void start()
        {
            while (true)
            {
                //Skapa ett enkelt inlogg???? hej hej 
                Console.WriteLine("Välkommen till Casono Avengers, välj ett av alternativen");
                Console.WriteLine("1. spela gissa numret");
                Console.WriteLine("2. Sätt in pengar");
                Console.WriteLine("3. Logga ut");
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