
// Define an object of type Person.
using ConsoleApp.ClassesDemo.Classes;
using System.Reflection.Metadata;

Person person;

Person baby = new Person();

baby.LastName = "Thompson";
baby.FirstName = "Theresa";
baby.DateofBirth = new DateOnly(2023,10,29);

baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();

var taxNumber = baby.GetTaxNumber();

Console.WriteLine(taxNumber);

var person1 = new Person("Developer", "One", new DateOnly(2000,10,31));

person1.PrintFullName();
person1.PrintInitials();

var person2 = new Person("Developer", "Two", "230023445");

person2.PrintFullName();
person2.PrintInitials();
person2.GenerateTaxNumber();

var teacher = new Teacher();
teacher.LastName = "Thompson";
teacher.FirstName = "Theresa";
teacher.DateofBirth = new DateOnly(2023, 10, 29);

teacher.PrintFullName();
teacher.PrintInitials();
teacher.GenerateTaxNumber();
var teacherIdNumber = teacher.GetIdNumber();

Student student = new();
student.LastName = "Thompson";
student.FirstName = "Theresa";
student.DateofBirth = new DateOnly(2023, 10, 29);

student.PrintFullName();
student.PrintInitials();
student.GenerateTaxNumber();
student.GenerateStudentIdNumber();
var studentIdNumber = student.GetIdNumber();

Rectangle reactangle = new(10, 20);
var reactangleAreal = reactangle.Area();

Square square = new(50);
var squareArea = square.Area();

public class Person
{
    public Person(DateOnly dob)
    {
        _age = DateTime.Now.Year - dob.Year;
        DateofBirth = dob;
    }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public decimal Salary { get; set; }
    public char Gender { get; set; }
    public bool IsWorking { get; set; }

    private readonly int _age;

    public int GetNumberOfWorkingYearsRemaining()
    {
        return Constants.retirementAge - _age;
    }

    public DateOnly GetEstimatedRetirementDate()
    {
        return DateOnly.FromDateTime(DateTime.Now.AddYears(GetNumberOfWorkingYearsRemaining()));
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}

public static class Constants
{
    public const int retirementAge = 65;
}