// See https://aka.ms/new-console-template for more information
Console.WriteLine("****************** - Methods - *******************");

// Void methods - complete a task returning a value
void PrintName()
{
    // Method code
    Console.WriteLine("My name");
}

// Value returning methods - returns a value after an operation
int GetFiveYearsAgo(int year)
{
    int yearDifference = DateTime.Now.Year - year;
    return yearDifference;
}

// Methods with parameters
void PrintNameWithParams(string name)                                                                                                                                                                                         
{
    // Method code
  Console.WriteLine(name);
}

// Methods with optional parameters
int GetFutureOrPastYear(int numberOfYears = 0)
{
    var year = DateTime.Now.AddYears(numberOfYears).Year;
    return year;
}

// Methods with nulllable parameters
void PrintNameNullableParam(string? name, int? count = 0)
{
    /*
    if (string.IsNullOrEmpty(name))
    {
        name = "Default Name";
    }
    if (!count.HasValue)
    {
        count = 1;
    }
    */

    name ??= "Default Name";
    count ??= 1;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(name);
    }
}

/* Function Calls */
PrintName();
int fiveYearsAgo = GetFiveYearsAgo(2000);
Console.WriteLine("Five Years Ago was: " + fiveYearsAgo);
PrintNameWithParams("Mike");
var pastYear1 = GetFutureOrPastYear();
PrintNameNullableParam(null, null);
PrintNameNullableParam("Chester", 5);