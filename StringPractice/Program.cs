
string sentence = "Hello     there everybody from planet earth!";

string[] words = sentence.Split();  // noun dot verb, the noun is a variable, in this case, sentence .

foreach (string word in words)
{
    Console.WriteLine(word);
}

Console.WriteLine();
Console.WriteLine("Split by commas:");

sentence = "Hello,there,everybody,from,planet earth!";


char[] delims = { ',', ' ' }; // Split by comma or space
words = sentence.Split(delims);

foreach (string word in words)
{
    Console.WriteLine(word);
}

Console.WriteLine();
Console.WriteLine();

// Let's join these words back together

sentence = string.Join(';', words);
Console.WriteLine(sentence);


Console.WriteLine();
Console.WriteLine();

// Let's join with spaces

sentence = string.Join(' ', words);  // noun dot verb, the nous is a TYPE, string. (think int.Parse).
                                     // Methods that are attached to the type itself are called "static methods".
                                     // Methods that are attached to an instance of the type (such as sentence) are called 
                                     //     instance methods.
Console.WriteLine(sentence);

Console.WriteLine();
Console.WriteLine();

// Let's find the position of a letter in a string
// IndexOf uses a common approach: It returns a 0-based index, or -1 if it doesn't find it.

sentence = "We will find a letter position";
Console.WriteLine(sentence.IndexOf('i'));
Console.WriteLine(sentence.IndexOf('x'));
Console.WriteLine();
Console.WriteLine(sentence.LastIndexOf('i'));
Console.WriteLine(sentence.LastIndexOf('x'));

Console.WriteLine();
Console.WriteLine();

// LET'S USE sUBSTRING TO FIND A PIECE OF A STRING
Console.WriteLine();
Console.WriteLine("Substring practice");
sentence = "Hello World";
Console.WriteLine(sentence.Substring(1)); // "ello World"
Console.WriteLine(sentence.Substring(3)); // "lo World"
Console.WriteLine(sentence.Substring(4, 3)); // "o W"

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Building a string");
