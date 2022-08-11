// remember that weird index -1 thing for user input/vs array 0th
bool res;
int num;
string entry, goAgain;

string[] names = { "Alfred", "Billy", "Caelid", "Dingus", "Euler" };
string[] towns = { "Auburn", "Boston", "Chicago", "Detroit", "Eastern" };
string[] foods = { "Apples", "Bananas", "Crepes", "Doritos", "Eggs" };


do
{
    Console.Write("Do you want to see all the students? Enter y/Y for yes or any other character for no: ");
    entry = Console.ReadLine();
    if (entry[0] == 'y')
    {
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"Student #{i + 1} is {names[i]}");
        }
    }


    Console.Write("Please enter a student ID# 1 to 5: ");
    entry = Console.ReadLine();
    res = int.TryParse(entry, out num);

    while (!res || num < 1 || num > names.Length)
    {
        Console.Write("Please try again with valid input: ");
        entry = Console.ReadLine();
        res = int.TryParse(entry, out num);
    }
    num--;

    Console.WriteLine($"\nStudent #{num + 1} is {names[num]}\n");

    Console.Write("Whatcha wanna know? Start your input with 'h' for hometown, or 'f' for fav food: ");
    entry = Console.ReadLine().ToLower();

    while (entry[0] != 'h' && entry[0] != 'f')
    {
        Console.WriteLine("Hmmm.. try again. Begin your input with 'h/H' for hometown or 'f/F' for favorite food");
        entry = Console.ReadLine().ToLower();
    }

    if (entry[0] == 'h')
    {
        Console.WriteLine($"{names[num]}'s hometown is {towns[num]}\n");
    }
    else
    {
        Console.WriteLine($"{names[num]}'s fav food is {foods[num]}\n");
    }

    Console.Write("Want to see another student's info? Enter y/Y for yes, or another key to exit the program: ");
    goAgain = Console.ReadLine();
} while (goAgain[0] == 'y');

