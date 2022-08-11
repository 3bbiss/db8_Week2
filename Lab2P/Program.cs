
decimal sum = 0;
string entry = string.Empty;
string entry2 = string.Empty;

Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
List<string> items = new List<string>();

static void showMenu(Dictionary<string, decimal> menu) // i keep forgetting this part and VS saves my ass. learn it.
{
    Console.WriteLine("Here's the menu!");
    Console.WriteLine("----------------");
    foreach (var item in menu)
    {
        Console.WriteLine($"{item.Key}: ${item.Value}\n");
    }
}

static void showOrder(List<string> order, Dictionary<string, decimal> menu)
{
    Console.WriteLine("\nYour order is below!");
    Console.WriteLine("-------------------");
    Console.WriteLine();
    foreach (var thing in order)
    {
        Console.WriteLine($"{thing}: ${menu[thing]}");
    }
    Console.WriteLine($"Your most expensive item is: {order.Max()}");
    Console.WriteLine($"Your least expensive item is: {order.Min()}");
}


menu["apples"] = 1.99m;
menu["bananas"] = 2.99m;
menu["carrots"] = 3.99m;
menu["dairy"] = 4.99m;
menu["eggs"] = 5.99m;
menu["figs"] = 6.99m;
menu["grapes"] = 7.99m;
menu["hake"] = 8.99m;

do
{
    Console.WriteLine("Please enter an item from the menu, or enter 'quit' to exit immediately.");
    showMenu(menu);
    entry = Console.ReadLine().ToLower();

    if (entry == "quit")
    {
        Console.WriteLine("\nThanks for shopping!");
        return;
    }

    while (!menu.ContainsKey(entry))
    {
        Console.Write("\nWe don't have that in stock! Please try again: ");
        showMenu(menu);
        entry = Console.ReadLine().ToLower();
    }

    items.Add(entry);
    sum += menu[entry];

    Console.Write("Want to add another item? Enter Y/y or another key to see your list: ");
    entry2 = Console.ReadLine().ToLower();
} while (entry2[0] == 'y');

showOrder(items, menu);
Console.WriteLine($"Your sum is: ${sum}");