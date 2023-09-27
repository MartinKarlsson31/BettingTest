using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting
{
    public partial class MyBetting
    {
        private double saldo;
        private void Deposit()
        {
            Console.WriteLine("Välkommen till bank Casono Avengers!");
            Console.WriteLine($"Ditt nuvarande saldo är:{saldo}");

            Console.Write("Ange belopp att sätta in: ");
            double insättning = double.Parse(Console.ReadLine());

            saldo += insättning;

            Console.WriteLine($"Ditt nya saldo är: {saldo}");

            Console.WriteLine("Tack för att du använder vår bank!");
            Console.WriteLine("tryck enter för att komma tillbaka till huvudmenyn");
            Console.ReadLine();
        }
    }
}
