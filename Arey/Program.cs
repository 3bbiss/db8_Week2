int num;      //tryParse
bool isValid; //tryParse
string entry; //tryParse
string entry2; //go again?


string[] names = { "Aleh", "Brogon", "Caelid", "Dingus", "Euler" };
int[] grades = { 100, 90, 80, 70, 60 };



do
{
    Console.WriteLine("Enter an integer from 1 to 5: ");
    entry = Console.ReadLine();
    isValid = int.TryParse(entry, out num);


    // getting a valid number from the user
    while (!isValid || num < 1 || num > 5)
    {
        Console.Write("Invalid entry. Try again: ");
        entry = Console.ReadLine();
        isValid = int.TryParse(entry, out num);
    }

    num--; // to fix array index (user expects 1-5, not 0-4).

    Console.WriteLine($"\n{names[num]} has grade {grades[num]}\n");


    // ask the user if they want to go again with input validation below
    Console.Write("Want go go again?: Enter yes or another key to quit: ");
    entry2 = Console.ReadLine().ToLower();

    while (entry2[0] != 'y' && entry2[0] != 'n')
    {
        Console.Write("That's not yes or no. Try again: ");
        entry2 = Console.ReadLine().ToLower();
    }

} while (entry2[0] == 'y' );