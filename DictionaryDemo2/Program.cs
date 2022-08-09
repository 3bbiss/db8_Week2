// More fun with dictionaries

// A list of salaries. The key will be a person's name (string)
// and the value will be the person's salary (decimal M)

Dictionary<string, decimal> Salaries = new Dictionary<string, decimal>();

Salaries["Paul"] = 65000m;
Salaries["Sarah"] = 100000m;
Salaries["Quincy"] = 80000m;
Salaries["Ruby"] = 90000m;
Salaries["Terry"] = 75000m;
Salaries["Fidan"] = 250000m;

//foreach (var pair in Salaries)
//{
//    Console.WriteLine(pair.Key);
//}

foreach (string key in Salaries.Keys)
{
    Console.WriteLine(key);
}


Console.WriteLine("Enter a name to lookup: ");
string name = Console.ReadLine();


if (Salaries.ContainsKey(name))
{
    Console.WriteLine(Salaries[name]);
}
else
{
    Console.WriteLine("That person doesn't work here.");
}

Console.Write("Please add a new employee. Enter their name: ");
string name2 = Console.ReadLine();
Console.Write("Please enter their salary: ");
string entry = Console.ReadLine();
decimal salary = decimal.Parse(entry);

Salaries[name2] = salary;

Console.WriteLine("Here's everybody: ");

foreach (var pair in Salaries)
{
    Console.WriteLine($"{pair.Key} makes {pair.Value}");
}