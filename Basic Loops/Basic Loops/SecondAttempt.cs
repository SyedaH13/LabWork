
public static class SecondAttempt
{
    public static void KeyLoop()
    {


        int codeAttempt = 0;
        bool doorIsLocked = true;
        do
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
        } while (doorIsLocked);
    }
}