// See https://aka.ms/new-console-template for more information

/*Use a do-while loop to output "Hello, World!" in a loop. Each time you output "Hello, World
ask the user whether they would like to continue. 
 */

bool userResponseYes = true;
do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue (y/n)?");
    string userResponse = Console.ReadLine();
    if (userResponse.ToLower() == "y")
    {
        userResponseYes = true;

    }
    else
    {
        userResponseYes = false;
        Console.WriteLine("Goodbye!");
    }
} while (userResponseYes == true);


/* Prompt the user for a number. Use a for loop to output all the numbers from that number 
to 0. after that loop finishes, use another loop to output all the numbers from 0 to that 
number 
 */




bool userResponseYes = true;
do
{
    Console.WriteLine("Enter a number: ");
    int userNum = int.Parse(Console.ReadLine());

    for (int i = userNum; i > 0; i--)
    {
        Console.WriteLine(i - 1);
    }
    for (int i = 0; i < userNum; i++)
    {
        Console.WriteLine(i + 1);
    }
    Console.WriteLine("Would you like to continue (y/n)?");
    string userResponse = Console.ReadLine();
    if (userResponse.ToLower() == "y")
    {
        userResponseYes = true;

    }
    else
    {
        userResponseYes = false;
        Console.WriteLine("Goodbye!");
    }
} while (userResponseYes == true);

/* The door combo is 13579 Write a loop (not do while) that asks the user to enter a key code 
 * the loop repeats as long as the user enters the code wrong. if the answer is right there will
 * be a welcome message. Create a bool for e.g doorIsLocked = true 
 */

bool doorIsLocked = true;
while (doorIsLocked)
{
    Console.WriteLine("Enter the key code for the door:");
    int enteredCode = int.Parse(Console.ReadLine());

    if (enteredCode == 13579)
    {
        Console.WriteLine("Welcome!");
        doorIsLocked = false;

    }
    else
    {
        doorIsLocked = true;
    }
}

/*
 */

int codeAttempt = 0;
bool doorIsLocked = true;
while (doorIsLocked)
{
    Console.WriteLine("Enter the key code for the door:");
    int enteredCode = int.Parse(Console.ReadLine());
    codeAttempt++;
    if (enteredCode == 13579)
    {
        Console.WriteLine("Welcome!");
        doorIsLocked = false;

    }
    else
    {
      
        doorIsLocked = true;
        if (codeAttempt > 4)
        {
            Console.WriteLine("too many attempts");
            break;
        }
    }
}
   


