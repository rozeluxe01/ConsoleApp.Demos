Console.WriteLine("********* Lists *********");

// Declare a List
List<int> grades = new List<int>();
List<string> students = new List<string>();
int grade = 0;
string name = string.Empty;
int gradeCount = 0;
int @continue = 0;
//var grades = new List<int>();
//List<int> grades = new();

// Add values to list
//grades.Add(45);
//grades.Add(23);
//grades.Add(33);
//Console.WriteLine(grades[0]);
//Console.WriteLine(grades[1]);
do
{
    gradeCount += 1;
    Console.Write("Enter Student Name:");
    name = Console.ReadLine();
    students.Add(name);

    Console.Write("Enter Grade:");
    grade = Convert.ToInt32(Console.ReadLine());
    if (grade != -1)
    {
        grades.Add(grade);
    }

    Console.WriteLine("Do you wish to continue? (1= yes | 2= no)");
    @continue = Convert.ToInt32(Console.ReadLine());
}
while (@continue != 2) ;

// Print values in list - for
Console.WriteLine("Printing students and grades via loop");
for (int i = 0; i < gradeCount; i++)
{
    Console.WriteLine($"{students[i]}: {grades[i]}");
}
// print values in list - foreach
//Console.WriteLine("Printing using foreach loop");
//foreach (int g in grades)
//{
//    Console.WriteLine(g);
//}
