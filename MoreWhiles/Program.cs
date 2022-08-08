
int x = 0;

//while (10 > 9)
//{
//    // infinite loop
//    Console.WriteLine($"While loop. x is {x}");
//    x++;
//}

//while (9 > 10)
//{
//    // 9 > 10 is false. Loop never runs.
//    Console.WriteLine($"While loop. x is {x}");
//    x++;
//}


bool done = false;
while (!done)
{
    Console.WriteLine($"While loop. x is {x}");
    x++;

    if (x == 1000)
    {
        done = true;
    }
}