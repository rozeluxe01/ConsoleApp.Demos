Console.WriteLine("*********** Arrays ***********");
// Tell me how many students and grades are to be entered?
Console.Write("Please indicate the number of grades to be entered");
int numberOfGrades = Convert.ToInt32(Console.ReadLine());
// Declare Fixed Size Array
int[] grades = new int[numberOfGrades];
string[] students = new string[numberOfGrades];
// 5 space addresses/indexes - 0 , 1, 2, 3, 4
// If n is the size of the array, then your array has addresses between 0 to n-1


// Add values to Fixed Size Array
//grades[0] = 45;
//grades[1] = 21;
//grades[2] = 38;
//grades[3] = 44;
//grades[4] = 22;
//grades[5] = 222;

for (int i = 0; i < grades.Length; i++)
{
    Console.Write("Enter Student Name:");
    students[i] = Console.ReadLine();

    Console.Write("Enter Grade:");
    grades[i] = Convert.ToInt32(Console.ReadLine());
    
}

// Print values in Fixed Size Array
Console.WriteLine("The grades you have entered are: ");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"{students[i]}: {grades[i]}");
}

//// Declare Variable Sized Array
//string[] studentNames = { "Newton", "Joshua", "etc..." };

//// Add values to Variable Sized Array
//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.Write("Enter Student Name:");
//    studentNames[i] = Console.ReadLine();

//}

//// Print values in Variable Sized Array
//Console.WriteLine("The grades you have entered are: ");
//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.WriteLine(studentNames[i]);
//}
