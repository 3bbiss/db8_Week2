Console.WriteLine("Let's do some Stack practice.");
Console.WriteLine();

Stack<string> cards = new Stack<string>();

cards.Push("3D");
cards.Push("AS");
cards.Push("QH");
cards.Push("");

string next = cards.Pop();

Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

//next = cards.Pop();   If we pop again, we'll get a "stack empty" exception

Console.WriteLine();
Console.WriteLine("Now let's practice some Queueueue.");

Queue<int> nums = new Queue<int>();

nums.Enqueue(5);
nums.Enqueue(10);
nums.Enqueue(15);
nums.Enqueue(20);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);

//Console.WriteLine(nums.Dequeue());  This line throws an exception "Queue empty"


Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Advanced stack stuff");
Console.WriteLine();
Console.WriteLine();

cards.Clear();  // Empties out the STACK

cards.Push("5D");
cards.Push("JH");
cards.Push("3S"); // So far we have 5D on the bottom, JH next on top, and 3S at the very top

Console.WriteLine(cards.Pop()); // expect 3S

string top = cards.Peek();
Console.WriteLine($"The top is {top} but we didn't remote it");

// We didn't remove JH, it's still there. So next Pop() will be JH.
Console.WriteLine(cards.Pop()); // expect JH

cards.Push("9H");
cards.Push("10D");
cards.Push("KS");

Console.WriteLine(cards.Pop()); // Expect KS because last one we Pushed.


cards.Push("5D");

// Now let's draw them all off

while (cards.Count > 0)
{
    next = cards.Pop();
    Console.WriteLine($"We just drew {next}");
}

Console.WriteLine("Count is now 0 zero");

Console.WriteLine();
Console.WriteLine();

// One more stack demo
Console.WriteLine("Let's put 5 cards on, and then draw them all off.");
cards.Clear();
cards.Push("AD");
cards.Push("2D");
cards.Push("3D");
cards.Push("4D");
cards.Push("5D");

while (cards.Count > 0)
{
    Console.WriteLine(cards.Pop());
}


// One more queue demo
Console.WriteLine();
Console.WriteLine("Let's put 5 numbers in a queue, and go thru the whole queue.");
nums.Clear();
nums.Enqueue(1);
nums.Enqueue(2);
nums.Enqueue(3);
nums.Enqueue(4);
nums.Enqueue(5);

while (nums.Count > 0)
{
    Console.WriteLine(nums.Dequeue());
}
