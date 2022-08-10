
string sentence = "";
string word = "";

do
{
    bool valid = false;
    while (!valid)
    {
        Console.WriteLine("Please enter a sentence: ");
        sentence = Console.ReadLine();

        if (sentence.Contains(' '))
        {
            valid = true;
        }
        else
        {
            Console.WriteLine("Make sure your sentence contains at least 1 space!");
        }
    }

    valid = false;

    while (!valid)
    {
        Console.WriteLine("Please enter a word: ");
        word = Console.ReadLine();

        if (word.Contains(' '))
        {
            Console.WriteLine("No spaces in your word!");
        }
        else
        {
            valid = true;
        }
    }


    bool contains = sentence.ToLower().Contains(word.ToLower());
    if (contains)
    {
        Console.WriteLine("That word exists!");
    }
    else
    {
        Console.WriteLine("No it aint found in the sentence!");
    }

} while (KeepGoing());

Console.WriteLine("Thanks for playing!");



static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("Would you like to go again? (y/n)");
        // Ask the user for their input
        string response = Console.ReadLine();
        response = response.ToLower();
        // Check if they typed "y". If so, return true.
        // Otherwise return false.   YES   yes
        if (response == "y" || response == "yes")
        {
            return true;
        }
        else if (response == "n" || response == "no")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please enter y or n");
        }
    }
}


// CLEAN INPUT VALIDATION
//Console.Write("Please enter a sentence: ");
//sentence = Console.ReadLine();


//while (!sentence.Contains(' '))
//{
//    Console.WriteLine("You need a space in your sentence! ");
//    sentence = Console.ReadLine();
//}