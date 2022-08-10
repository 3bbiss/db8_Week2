
Console.Write("Hello! Please enter a word or sentence to be reversed: ");
string sentence = Console.ReadLine(); // get user input
string[] wrds = sentence.Split(' '); // separate input into string array 
                                    //
                                   // for each word in user's inputted
foreach (string wrd in wrds)      // sentence, reverse & print it.
{
    Console.Write($" {reverse(wrd)}");
    //Console.Write(reverse(word));
}


static string reverse(string input)
{
    string reversed = "";  // variable that will hold reversed word(s)
    Stack<string> word = new Stack<string>();  // STACK - LIFO. Good for reverse order of insertion.

    // for each letter in each word, convert it to a string and PUSH it to STACK word
    for (int i = 0; i < input.Length; i++)
    {
        word.Push(input[i].ToString());
    }

    // getting (Popping) the elements from the stack in reverse order, storing in next via concatenation
    while (word.Count > 0)
    {
        reversed += string.Concat(word.Pop());
    }
    return reversed;
}
