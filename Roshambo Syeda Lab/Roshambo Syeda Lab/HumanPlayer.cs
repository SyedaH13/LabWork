using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//HumanPlayer - Allows the user to select and throw a value.
//Upon creating an instance of this class, allow the user to input their name
namespace Roshambo_Syeda_Lab
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer()
        {
            Console.WriteLine("Enter your name:");
            Console.ReadLine();
        }
        public override Roshambo GenerateRoshambo()
        {
            Console.WriteLine("Rock, Paper, or Scissors? (r/p/s)");
            string userRps = Console.ReadLine().ToLower();

            bool enteredCorrect = false;
            do
            {

                if (userRps == "r")
                {
                    return Roshambo.Rock;
                }
                else if (userRps == "p")
                {
                    return Roshambo.Paper;
                }
                else if (userRps == "s")
                {
                    return Roshambo.Scissors;
                }
                else
                {
                    Console.WriteLine("invalid input, please pick rock paper or scissors (r/p/s)");
                    enteredCorrect = false;
                     
                }
            }while (true);
        }
    }
}
 