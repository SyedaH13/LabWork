// See https://aka.ms/new-console-template for more information

//ROCK PAPER SCISSORS GAME!
/*
 * The application prompts the player to enter a name and select an opponent.
The application prompts the player to select rock, paper, or scissors.
Then, the application displays the player’s choice, the opponent’s choice, and the result 
The application continues until the user doesn’t want to play anymore.
If the user makes an invalid selection, the application should display an appropriate error message 
and prompt the user again until the user makes a valid selection.
*/
/*
 * Create a main where you create a HumanPlayer and then allow them to choose their opponent: either
 * RockPlayer or RandomPlayer.
Validate your user inputs throughout your app.
Try catch blocks, if statements, or any other method of validation is good.
Hints:
Paper beats rock, rock beats scissors, scissors beats paper. 
 */
using Roshambo_Syeda_Lab;
using System.ComponentModel.Design;

Console.WriteLine("Welcome to Rock Paper Scissors!");

HumanPlayer humanPlayer1 = new HumanPlayer();
Player computer = new RockPlayer();

Console.WriteLine("Would you like to play against The Jets or TheSharks? (j/s)?");
string chosenTeam = Console.ReadLine().ToLower();

if (chosenTeam == "j")
{
   computer = new RockPlayer() { Name = "The Jets"};
}
else if (chosenTeam == "s")
{
   computer = new RandomPlayer() { Name = "The Sharks" };
} 
else
{
    Console.WriteLine("invalid input!");
}

bool playAgain = true;
do
{
    Roshambo HumanPlayerChose = humanPlayer1.GenerateRoshambo();
    Console.WriteLine($"{humanPlayer1.Name}:{HumanPlayerChose}");

    Roshambo computerChoice = computer.GenerateRoshambo();
    Console.WriteLine($"{computer.Name}:{computerChoice}");


    //Paper beats rock, rock beats scissors, scissors beats paper. 
    if (HumanPlayerChose == Roshambo.Paper && computerChoice == Roshambo.Rock)
    {
        Console.WriteLine($"{humanPlayer1.Name} wins");
    }
    else if (HumanPlayerChose == Roshambo.Rock && computerChoice == Roshambo.Scissors)
    {
        Console.WriteLine($"{humanPlayer1.Name} wins");
    }
    else if (HumanPlayerChose == Roshambo.Scissors && computerChoice == Roshambo.Paper)
    {
        Console.WriteLine($"{humanPlayer1.Name} wins");
    }
    else if (HumanPlayerChose == computerChoice)
    {
        Console.WriteLine("Draw");
    }
    else
    {
        Console.WriteLine($"{computer.Name} wins");
    }

    Console.WriteLine("would you like to try again (y/n)");
    string tryAgain = Console.ReadLine();
    if (tryAgain.ToLower() == "n")
    {
        playAgain = false;
        break;
    }
} while (playAgain);
