
using System.Security.Cryptography;

Console.WriteLine("***************** - Classes and Objects - *******************");
// Define a class
public class Person
{
    public Person(string firstName, string lastName, DateOnly dob) { 
        FirstName = firstName;
        LastName = lastName;
        DateofBirth = dob;
    }

    public Person(string firstName, string lastName, string taxNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        _taxNumber = taxNumber;
    }


    // Properties/Data Members
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateOnly DateofBirth { get; set; }

    // Field member
    private string _taxNumber;
    protected string _idNumber = "N/A";

    public void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }

    public void PrintInitials()
    {
        var firstInitial = FirstName[0];
        var lastInitial = LastName[0];
        Console.WriteLine($"{firstInitial} {lastInitial}");
    }

    public void GenerateTaxNumber()
    {
        if (string.IsNullOrEmpty( _taxNumber ) )
        {
            _taxNumber = RandomNumberGenerator.GetInt32(100000, 9999999).ToString();
        }
        else
        {
            Console.WriteLine($"Tax number already exists for {FirstName} {LastName}");
        }
    }

    public string GetTaxNumber()
    {
        return _taxNumber;
    }

    protected string GetRandomNumber()
    {
        return RandomNumberGenerator.GetInt32(100000, 9999999).ToString();
    }
}