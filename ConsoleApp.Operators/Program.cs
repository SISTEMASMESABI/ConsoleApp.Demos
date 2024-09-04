// See https://aka.ms/new-console-template for more information

Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = 0;
Console.Write("Please enter the second number: ");
string numberEntered = Console.ReadLine();
num2 = Convert.ToInt32(numberEntered);

/*
    Math Operations and operators
 */

// Add numbers
int sum = num1 + num2;

// Multiply
int product = num1 * num2;

// Division
int quotient = num1 / num2;

// Subtraction
int difference = num1 - num2;

// Modulus
int mod = num1 % num2;

Console.WriteLine("******************* Math Results ****************");
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine();
Console.WriteLine("******************* End Math Results ****************");

/*
    Logic Operations and Operators
 */

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("******************* Logic Results ****************");
Console.WriteLine();
Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Equal To: {isEqualTo}");
Console.WriteLine($"Is Greater Than Or Equal To: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than Or Equal To: {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal: {isNotEqual}");
Console.WriteLine();
Console.WriteLine("******************* End Logic Results ****************");


/*
    Assignment Operations and Operators
 */

Console.WriteLine("******************* Logic Results ****************");
Console.WriteLine();
Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Equal To: {isEqualTo}");
Console.WriteLine($"Is Greater Than Or Equal To: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than Or Equal To: {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal: {isNotEqual}");
Console.WriteLine();
Console.WriteLine("******************* End Logic Results ****************");



