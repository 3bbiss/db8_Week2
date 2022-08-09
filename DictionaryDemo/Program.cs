// Let's start with a list for comparison

List<string> letters = new List<string>() { "Abc", "Def", "Ghi", "Jkl", "Mno" };

Console.WriteLine("Here're the letters.");
foreach (string werd in letters)
{
    Console.WriteLine(werd);
}


Dictionary<string, string> foods = new Dictionary<string, string>();

foods["Paul"] = "Spaghetti";
foods["Sarah"] = "Pizza";
foods["Quincy"] = "Tacos";
foods["Ruby"] = "Ice Cream";
foods["Terry"] = "Tacos";

// Let's print out Ruby's favorite food
Console.WriteLine("Here is Ruby's favorite food:");
Console.WriteLine(foods["Ruby"]);

// Paul changed his mind. He likes burgers.
foods["Paul"] = "Burgers";

Console.WriteLine($"Here is Paul's fav food: {foods["Paul"]}");

foreach (var pair in foods)
{
    Console.WriteLine("The name and the food are:");
    Console.WriteLine(pair.Key);
    Console.WriteLine(pair.Value);
    Console.WriteLine();
}

// Check if an item exists in the dictionary

string entry = Console.ReadLine();
if (foods.ContainsKey(entry))
{
    Console.WriteLine($"Yes, we have a favorite food for {entry}");
    Console.WriteLine(foods[entry]);
}
else
{
    Console.WriteLine("We don't know that person.");
}