// Unit 2
for (int i = 10; i > 0; i -= 3)
{
    Console.WriteLine(i);
    if (i == 4) break;
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

// Unit 3
for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0)
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else
        Console.WriteLine($"{i}");
}