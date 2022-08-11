
Console.WriteLine("Enter a sentence/word to have it reversed!");
string entry = Console.ReadLine().ToLower();
string[] words = entry.Split(' ');

foreach (string wrd in words)
{
    Console.Write($"{reverseMe(wrd)} " );
}

static string reverseMe(string input)
{
    string rev = string.Empty;
    Stack<string> chars = new Stack<string>();

    for (int i = 0; i < input.Length; i++)
    {
        chars.Push(input[i].ToString());
    }

    while(chars.Count > 0)
    {
        rev += chars.Pop();
    }
    return rev;
}