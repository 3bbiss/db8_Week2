
int num;      //tryParse
bool isValid; //tryParse
string entry; //tryParse
string entry2; //go again?

string[] names = { "Alex", "Bob", "Cat", "Dave", "Ed" };
string[] hometowns = { "Atlanta", "Baltimore", "Chicago", "Detroit", "East" };
string[] foods = { "Apple", "Bread", "Chocolate", "DairyQ", "Easter eggs" };

do
{
    // ask user for integer within valid range --- includes input validation below
    
    Console.WriteLine("Enter an ID number from 1-5");
    entry = Console.ReadLine();
    isValid = int.TryParse(entry, out num);

    while (!isValid || num < 1 || num > names.Length)
    {
        Console.WriteLine("Invalid input. Try again please!: ");
        entry = Console.ReadLine();
        isValid = int.TryParse(entry, out num);
    }

    num--;  // to fix the array index issue. User expects range 1 to array.length  ... not 0 to arr.len-1

    Console.WriteLine($"You entered ID #{num + 1} who is {names[num]}");

    Console.WriteLine("Which category do you want to see? Enter H/h for hometown, or F/f for foods!");
    entry = Console.ReadLine().ToLower();

    // input validation for user category
    while (entry[0] != 'h' && entry[0] != 'f')
    {
        Console.WriteLine("That's invalid input! Please try again with H/h, or F/f! :)");
        entry = Console.ReadLine().ToLower();
    }
    
    // hometown flow
    if (entry[0] == 'h')
    {
        Console.WriteLine($"{names[num]}'s hometown is: {hometowns[num]}");    
    }
    // fav food flow
    else
    {
        Console.WriteLine($"{names[num]}'s favorite food is: {foods[num]}");    
    }

// ask the user if they want to go again with input validation below
    Console.Write("Want go go again?: Enter y/Y or n/N: ");
    entry2 = Console.ReadLine().ToLower();

    while (entry2[0] != 'y' && entry2[0] != 'n')
    {
        Console.Write("That's not y/Y or n/N. Please try again! :) ");
        entry2 = Console.ReadLine().ToLower();
    }
} while (entry2[0] == 'y');


