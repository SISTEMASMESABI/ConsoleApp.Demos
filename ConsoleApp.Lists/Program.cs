// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Declare a List
List<int> grades = new List<int>();
int grade = 0;

// Add values to list
do
{
    Console.WriteLine("Enter Grade: ");
    grade = Convert.ToInt32(Console.ReadLine());
    if (grade != -1)
    {
        grades.Add(grade);
    }
} while (grade != -1);

// Print values in list - for
Console.WriteLine("Printing names via for loop");
for (int i = 0; i < grades.Count; i++)
{
    Console.WriteLine(grades[i]);
}

// Print values in list - foreach
foreach (int g in grades)
{
    Console.WriteLine(g);
}