// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello. What is your name?");
string userName = Console.ReadLine();

Console.WriteLine($"{userName}, please enter an integer between 1 and 100 inclusive.");
string pickedNum = Console.ReadLine();
int chosenNum = int.Parse(pickedNum);

if (chosenNum % 2 != 0 && chosenNum > 0 && chosenNum < 61)
{
    Console.WriteLine($"{chosenNum} is odd and less than 60.");
}
else if (chosenNum % 2 == 0 && chosenNum > 1 && chosenNum < 25)
{
    Console.WriteLine($"{chosenNum} is even and less than 25");
}
else if (chosenNum % 2 == 0 && chosenNum > 25 && chosenNum < 61)
{
    Console.WriteLine($"{chosenNum} is even and between 26 and 60 inclusive");
}
else if (chosenNum % 2 == 0 && chosenNum > 60 && chosenNum < 101)
{
    Console.WriteLine($"{chosenNum} is even and greater than 60");
}
else if (chosenNum % 2 != 0 && chosenNum > 60 && chosenNum < 101)
{
    Console.WriteLine($"{chosenNum} is odd and greater than 60");
}
else
{
    Console.WriteLine($"{userName}, you did not enter a valid input of an integer between 1 and 100 inclusive");
}
