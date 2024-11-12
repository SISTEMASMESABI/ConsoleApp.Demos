// See https://aka.ms/new-console-template for more information

// Simple For Loop Demo
// Print Hello World 10 times

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello, World! - {i}");
}

Console.WriteLine("Loop Completed!");

// Ask User how many times they wish to print hello world and print accordingly
Console.WriteLine("How many times should we print hello world?");
int userCount = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < userCount; i++)
{
    Console.WriteLine($"Hello, World! - {i}");
}

Console.WriteLine("************* Simple For Loop Completed ***********");

// While Loop
Console.WriteLine("************* Simple While Loop ***********");

int counter = 0;

while (counter < 10)
{
    Console.WriteLine($"Hello World - {counter}");
    counter++;
}

// Ask the user for a number and find the total for each number that is entered. Print final sum when the user -1 exit.

int sum = 0;
int num = 0;

while (num != -1)
{
    Console.Write("Please enter a number to be summed. (-1 to stop exit): ");
    num = Convert.ToInt32(Console.ReadLine());

    // nested if statement
    if (num != -1)
    {
        sum += num;
    }
}

Console.WriteLine($"Your sum is: {sum}");

Console.WriteLine("************* Simple Whille Loop Completed ***********");