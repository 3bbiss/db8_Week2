// An array is a variable that can hold a list of homogenous objects

int[] grades = {100, 80, 100, 60, 80};

//Console.WriteLine(grades[0]);
//Console.WriteLine(grades[1]);
//Console.WriteLine(grades[4]);


//foreach (int grade in grades)
//{
//    Console.WriteLine(grade);
//}


string[] names = { "Leroy", "Elroy", "Fred", "Derf" };
Console.WriteLine(names[0]);
Console.WriteLine(names[2]);

Console.WriteLine();
int index = 3;
Console.WriteLine(names[3]);
Console.WriteLine(names[index]);
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < 4; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine();

for (int i = 0; i <= 3; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine();

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine();

// Let's change one of the names in the names[] array
names[2] = "Jasmine";
Console.WriteLine($"We corrected the spelling of {names[2]}: ");
Console.WriteLine();

// Let's change one of the grades in the grades[] array
Console.WriteLine(grades[0]);
grades[0] = 99;
Console.WriteLine(grades[0]);