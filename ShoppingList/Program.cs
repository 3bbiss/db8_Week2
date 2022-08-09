string entry, entry2;
decimal sum = 0;

List<string> things = new List<string>() { };

Dictionary<string, decimal> menu = new Dictionary<string, decimal>();

static void showMenu(Dictionary<string, decimal> menu)
{
    Console.WriteLine("Here's the menu: ");
    Console.WriteLine("---------------");
    foreach (var item in menu)
    {
        Console.Write(item.Key);
        Console.Write(":  ");
        Console.Write(item.Value);
        Console.WriteLine();
    }
}

static void showOrder(List<string> things)
{
    Console.WriteLine("Here's your order: ");
    Console.WriteLine("-----------------");
    foreach (string thing in things)
    {
        Console.WriteLine(thing);
        Console.WriteLine();
    }
}

// ---------------------------------------------------------------------------------

menu["apples"] = 1.99m;
menu["bananas"] = 2.99m;
menu["candy"] = 3.99m;
menu["dates"] = 4.99m;
menu["eggs"] = 5.99m;
menu["figs"] = 6.99m;
menu["grapes"] = 7.99m;
menu["hake"] = 8.99m;



do
{
    // get user's item they want to order
    Console.WriteLine("What item do you want to order?");
    showMenu(menu);
    entry = Console.ReadLine().ToLower();

    // if user entry is not in the menu, have them retry 
    while (!menu.ContainsKey(entry.ToLower()))
    {
        Console.WriteLine("\nThat item doesn't exist!");
        Console.WriteLine("Try again to order something!\n");
        showMenu(menu);
        entry = Console.ReadLine().ToLower();
    }

    // if user's input is valid (in the menu), add it to the LIST w/ price
    things.Add($" {entry} : {menu[entry]}");
    sum += menu[entry];

    showOrder(things);
    Console.WriteLine(sum);



    // ask the user if they want to go again with input validation below
    Console.Write("Want go go again?: Enter y/Y or n/N: ");
    entry2 = Console.ReadLine().ToLower();

    while (entry2[0] != 'y' && entry2[0] != 'n')
    {
        Console.Write("That's not y/Y or n/N. Please try again! :) ");
        entry2 = Console.ReadLine().ToLower();
    }
} while (entry2[0] == 'y');

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Your sum is: ${sum}");
showOrder(things);