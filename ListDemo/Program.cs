// Let's make an array for comparison
string[] myArray = { "abc", "def", "ghi" };

// Let's print out one element
Console.WriteLine(myArray[0]);

// Let's change one of the elements
myArray[1] = "jkl";

// Let's loop through it
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}

Console.WriteLine();


// Let's use a list

List<string> myList = new List<string>();
myList.Add("Abc");
myList.Add("Def");
myList.Add("Ghi");

// Let's pring out an element
Console.WriteLine(myList[0]);

// Let's change one of the elements
myList[1] = "Jkl";

// Let's add another element to the LIST
myList.Add("Mno");

for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i]);
}

// Remove one from the list
myList.RemoveAt(2);

for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i]);
}


myList.Remove("Abc");

for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i]);
}

// Insert one into the list
Console.WriteLine("Now let's insert one in between the first two.");
myList.Insert(1, "eyo!");

foreach (string word in myList)
{
    Console.WriteLine(word);
}

// Some functions modify the list. They actually do change the list itself, unlike string Fns.

Console.WriteLine("Let's sort the list.");

myList.Sort();

foreach (string word in myList)
{
    Console.WriteLine(word);
}


// Let's check if an element exists
Console.WriteLine("Enter a word and we'll see if it exists in the LIST: ");
string entry = Console.ReadLine();
int index = myList.IndexOf(entry);

if (index >= 0)
{
    Console.WriteLine($"Found {entry} at {index}");
}
else
{
    Console.WriteLine($"{entry} is not in the list!");
}


// Let's initialize a new list of ints
List<int> numbers = new List<int>() { 5, 3, 8, 2 };
foreach (int num in numbers)
{
    Console.WriteLine($"The next number is: {num}");
}
