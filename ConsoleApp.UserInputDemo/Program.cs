// Declare variables
// collect age and name
string? firstName = string.Empty;
string lastName = string.Empty;
int age;
int retirementAge = 65;
decimal salary = 0;
char gender = char.MinValue;
bool working = false;

// Prompt the user for input
Console.Write("please enter your first name: ");
firstName = Console.ReadLine();

Console.Write("please enter your last name: ");
lastName = Console.ReadLine();

Console.Write("please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("please enter your salary: ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

// Process the data
int workingYearsRemaining = retirementAge - age;

// Output the results to the user
Console.WriteLine($"Full Name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your Salary is: {salary}");
Console.WriteLine($"Your Gender is: {gender}");
Console.WriteLine($"You are Employed: {working}");
Console.WriteLine($"Number of working Years Remaining: {workingYearsRemaining}"); 