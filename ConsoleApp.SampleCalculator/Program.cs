﻿// See https://aka.ms/new-console-template for more information
// Welcome Message
Console.WriteLine("********* - Welcome to the sample calculator! - *********");

// Prompt for user input
Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Show calculator options / Show menu
Console.WriteLine("Please select an operation");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Substraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");

int choice = Convert.ToInt32(Console.ReadLine());

// Decide which operation is needed based on selected option
/* Switch statemennt */

int answer = 0;
switch (choice)
{
    case 1:
        /* Do addition */
        answer = num1 + num2;
        break;
    case 2:
        /* Substraction */
        answer = num1 - num2;
        break;
    case 3:
        /* Multiplication */
        answer = num1 * num2;
        break;
    case 4:
        /* Division */
        answer = num1 / num2;
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}
// Print output
Console.WriteLine($"The result is: {answer}");