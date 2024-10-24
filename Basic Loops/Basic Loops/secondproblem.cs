

//int entryTries = 0;

//do  
//{
//    bool doorIsLocked = true;
//    while (doorIsLocked)
//    {
//        Console.WriteLine("Enter the key code for the door:");
//        int enteredCode = int.Parse(Console.ReadLine());

//        if (enteredCode == 13579)
//        {
//            Console.WriteLine("Welcome!");
//            doorIsLocked = false;

//        }
//        else
//        {
            
//           doorIsLocked = true;
//            entryTries++;
//        }
//   }

//} while (entryTries < 5)
//Console.WriteLine("Too many incorrect tries");


//int codeAttempt = 5;
//for (int i = 0; i < codeAttempt; i++)
//{
//    bool doorIsLocked = true;
//    while (doorIsLocked && codeAttempt < 6)
//    {
//        Console.WriteLine("Enter the key code for the door:");
//        int enteredCode = int.Parse(Console.ReadLine());

//        if (enteredCode == 13579)
//        {
//            Console.WriteLine("Welcome!");
//            doorIsLocked = false;

//        }
//        else
//        {
//            i++;
//            doorIsLocked = true;
//            if (codeAttempt > 5)
//            {
//                Console.WriteLine("too many attempts");
//            }
//        }
//    }

//}