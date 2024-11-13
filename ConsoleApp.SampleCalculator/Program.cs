// See https://aka.ms/new-console-template for more information
// Welcome Message
Console.WriteLine("********* - Welcome to the sample calculator! - *********");

// Variable Declarations
int choice = 0;
int num1, num2;

// Show calculator options / show menu
while (choice != -1)
{
	try
	{
        Console.WriteLine("Please select an operation (-1 to exit program) ");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Substraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Fibonacci sequence");
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == -1)
        {
            break;
        }

        Console.Write("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

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
            case 5:
                for (int i = num1; i <= num2; i++)
                {
                    answer += i;
                }
                break;
            default:
                throw new Exception("Invalid Menu Item Selected.")
        }

        // Print output
        Console.WriteLine($"The result is: {answer}");
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
        Console.Clear();
    }
    catch (DivideByZeroException)
    {

        Console.WriteLine("Cannot devide by zero");
  

    }
    catch (Exception ex)
	{
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();
    }
}

