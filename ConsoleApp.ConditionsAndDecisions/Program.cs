// See https://aka.ms/new-console-template for more information

// Propmt for input
Console.Write("Please enter a student's grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

// Decide to print pass or fail based on input
if (grade > 50)
{
    Console.WriteLine("Student has passed");
} 
else
{
    Console.WriteLine("Student has failed");
    Console.WriteLine("Please recommed student to student affair's office");
}

Console.WriteLine("Thank you for using this program");

Console.WriteLine("*************** Complex IF..ELSE IF Results ***************");

/*
 * A: 86 -100
 * B: 75 - 84
 * C: 65 - 74
 * C-: 50 - 64
 * F: less than 50
 */


if (grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid value entered");
}
else if (grade < 50)
{
    Console.WriteLine("Student has failed - F");
}
else if (grade >= 50 && grade <= 64)
{
    Console.WriteLine("C-");
}
else if (grade >= 65 && grade <= 74)
{
    Console.WriteLine("C");
}
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("B");
}
else if (grade >= 85 && grade <= 100)
{
    Console.WriteLine("A - Good job");
}

int gradeAfterBonus = grade >= 0 && grade <= 100 ? grade + 10 : 0;
Console.WriteLine($"Grade after bonus: {gradeAfterBonus}");

Console.WriteLine("**************** Complex IF..ELSE IF Results End *****************");

// Ternary operator - Used to assign s value to a variable based on  a condition.
Console.WriteLine("**************** Ternary Operator Result **************************");

string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine($"Student status is: {passStatus}");

Console.WriteLine("**************** Ternary Operator Result End **********************");

// Switch statements - Used to evaluate a value and take action.
Console.WriteLine("**************** Switch Statement Result **************************");
/*
 * Write a program to accept an integer as the day of the week and print the appropriate message a s outlined below.
 * 1 - Sunday
 * 2 - Monday
 * 3 - Tuesday
 * 4 - Wedneday (Hump Day!)
 * 5 - Thursday
 * 6 - Friday (TGIF!!!)
 * 7 - Saturday (Beach Day!!!)
 */

Console.Write("Please enter the day of the week: ");

int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wedneday (Hump Day!)");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday (TGIF!!!)");
        break;
    case 7:
        Console.WriteLine("Saturday (Beach Day!!!)");
        break;
    default:
        Console.WriteLine("Invalid day number entered!!");
        break;
}


Console.WriteLine("**************** Switch Statement End **********************");

// The rest of the application
Console.WriteLine("Thank you for using this program");