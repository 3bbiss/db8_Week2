string entry;
int num;
bool res;

//do
//{
//    Console.WriteLine("Enter an integer");
//    entry = Console.ReadLine();

//    res = int.TryParse(entry, out num);

//    Console.WriteLine(res);
//    Console.WriteLine(num);
//} while (!res) ;

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Enter an integer");
    entry = Console.ReadLine();

    res = int.TryParse(entry, out num);
    if (res)
    {
        Console.WriteLine($"Great! Your number is {num}");
    }
    else
    {
        Console.WriteLine($"Sorry, {entry} is not an integer.");
    }
}