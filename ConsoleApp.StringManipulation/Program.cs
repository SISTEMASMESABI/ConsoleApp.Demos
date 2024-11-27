// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Initialize with a regular string literal.
string s1 = "This is a literal string";
String s2 = "This is a literal string";

// Declare without initializing. (possible null exception).
string s3;

// Initialize to null. (possible null exception).
string? s4 = null;

// Initialize as an empty string.
string s5 = string.Empty; // ""
string s6 = "";

// Escape sequences and characters
// She said, "I have your phone"
string sentence = "She said, \"I have your phone\"\r\n This is the next line";

// Verbatim strig literal.
string oldPath = "C:\\program files\\programfolder\\";
string newPath = @"C:\\program files\programfolder\\";

// Use a const string to prevent modification to a string
const string path = "C:\\program files\\programfolder\\";

// Raw string literals
string rawLiteral = """ She said, "I have your phone" """;
string rawLiteral1 = """
    She said, "I have your phone"
    This is the next line
    And another one
    path = "C:\\program files\\programfolder\\"
    """;

// Review concatenation and interpolation
s1 = s1 + s2;
s1 += s2;
string newString = $"{s1} {s2} Some random literal text";
string newString1 = s1 + $"{s1} {s2} Some random literal text";
string newString2 = String.Format("Literal string {0} {1}", s1, s2);

/* String manipulation methods and properties */

// Null or empty check
// Find the length of a string
Console.WriteLine($"{nameof(s1)} has a length of {s1.Length}");


if (!string.IsNullOrEmpty( s4 ))
{
    Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");
}

if (!string.IsNullOrEmpty(s5) == false)
{
    Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");
}

// Substrings
string subString = s1.Substring(5);
Console.WriteLine($"{nameof(subString)} : {subString}");
subString = s1.Substring(5, 5);
Console.WriteLine($"{nameof(subString)} : {subString}");

// Splitting strings
var splitStrings = s2.Split(' ');

for (int i = 0; i < splitStrings.Length; i++)
{
    Console.WriteLine($"{splitStrings[i]}");    
}

// Replace
string replacements = s1.Replace('s', 'V');
Console.WriteLine($"{nameof(replacements)} : {replacements}");

string replacements2 = s1.Replace("string", "chicken");
Console.WriteLine($"{nameof(replacements2)} : {replacements2}");

// Convvert to string
string salary = 2020203030202.02.ToString();
int value = 2030022;
string strValue = value.ToString();
bool chosen = true;

chosen.ToString();

// Changing Formatting
Console.WriteLine($"{nameof(salary)} : {salary:C}");
Console.WriteLine(nameof(salary) + ": " + value.ToString("C"));