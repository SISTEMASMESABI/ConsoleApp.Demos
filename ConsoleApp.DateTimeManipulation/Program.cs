// See https://aka.ms/new-console-template for more information

// Empty DateTime
DateTime dateTime = new DateTime();

// Create a DateTime from date and time
var dateOfBirth = new DateTime(1980,12,25);
Console.WriteLine($"My Dob is: {dateOfBirth}");

var exactDateAndTimeOfBirth = new DateTime(1980, 12, 25, 14, 45, 25, DateTimeKind.Local);
Console.WriteLine($"My Dob is: {exactDateAndTimeOfBirth}");

Console.WriteLine($"Day of Week: {dateOfBirth.DayOfWeek}");
Console.WriteLine($"Day of Year: {dateOfBirth.DayOfYear}");
Console.WriteLine($"Time of Day: {dateOfBirth.TimeOfDay}");
Console.WriteLine($"Tick: {exactDateAndTimeOfBirth.Ticks}");
Console.WriteLine($"Kind: {exactDateAndTimeOfBirth.Kind}");

// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("The Time Now Is: " + now);

// Create a DateTime from a string
Console.WriteLine("What is your DOB (dd/MM/yyyy): ");
string dob = Console.ReadLine();

var userDob = DateTime.Parse(dob);
Console.WriteLine($"Day of Week: {userDob.DayOfWeek}");
Console.WriteLine($"Day of Year: {userDob.DayOfYear}");
Console.WriteLine($"Time of Day: {userDob.TimeOfDay}");
Console.WriteLine($"Tick: {userDob.Ticks}");
Console.WriteLine($"Kind: {userDob.Kind}");

// Change Format DateTime
Console.WriteLine($"Formatted Date: {userDob.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Formatted Date: {userDob.ToString("MMM, dd-yyyy")}");
Console.WriteLine($"Formatted Date: {userDob.ToString("dddd-MMMM-yyyy")}");
Console.WriteLine($"Formatted Date: {userDob.ToString("dddd-MMMM-yyyy")}");

// Add Additional Time
Console.WriteLine("One hour now is: " + now.AddHours(1));
Console.WriteLine("One day now is: " + now.AddDays(1));
Console.WriteLine("One day from now is: " + now.AddDays(-1));

// UTC
var utcNow = DateTime.UtcNow;
Console.WriteLine($"Now Date Time: {now}");
Console.WriteLine($"UTC Now Date Time: {utcNow}");

// DateTimeOffSet and TimeZone Info
var tz = TimeZoneInfo.Local.GetUtcOffset(utcNow);
Console.WriteLine($"User Time Zone: {tz}");

var dto = new DateTimeOffset(now, tz);
Console.WriteLine($"User Time Zone with UTC Offset: {dto}");
Console.WriteLine($"UTC Time of Action: {dto.UtcDateTime}");
                                            
var indiaTz = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
var indiaDateTime = TimeZoneInfo.ConvertTimeToUtc(dto.UtcDateTime, indiaTz);
Console.WriteLine($"Action was completted in India at: {indiaDateTime}");

// DateOnly
var dateOnly = new DateOnly(1980, 12, 25);

// TimeOnly