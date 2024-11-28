
Console.WriteLine("Please indicate the number of grades to be entered: ");
int numberOfGrades = Convert.ToInt32(Console.ReadLine());

int[] grades = new int[numberOfGrades];
string[] students = new string[numberOfGrades];

for (int i = 0; i < numberOfGrades; i++)
{
    Console.Write("Enter Student Name: ");
    students[i] = Console.ReadLine();

    Console.Write("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("The Grades you have entered are: ");
for (int i = 0; i < numberOfGrades; i++)
{
    Console.WriteLine($"{students[i]} : {grades[i]}");
}