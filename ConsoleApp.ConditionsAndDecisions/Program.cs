


// Prompt for input
Console.Write("Please enter student's grade: ");
// Global variable/ global scope
int grade = Convert.ToInt32(Console.ReadLine());


// Simple If...Else...Statement - Decide to print pass or fail based on input
Console.WriteLine("******************* Simple IF Results *******************");
if (grade > 50)
{
    // grade is greater than 50
    Console.WriteLine("Student has passed");
}
else
{
    // grade is less than 50
    Console.WriteLine("Studen has failed");
    Console.WriteLine("Please recommend student to student affair's office");
}
Console.WriteLine("******************* Simple IF Results End *******************");


// Complex If...Else...Statement - Decide to print pass or fail based on input

Console.WriteLine("******************* Complex IF..Else IF Results *******************");


/*
 * A: 85 - 100 X
 * B: 75 - 84 X
 * C: 65 - 64 X
 * C-: 50 - 64 X
 * F: less than 50 X
 */



if(grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid Value Entered");
}
else if(grade < 50)
{
    Console.WriteLine("Student has failed - F");
}
else if(grade >= 50  && grade <= 64)
{
    Console.WriteLine("C-");
}
else if (grade >= 65 && grade <= 74)
{
    Console.WriteLine("C");
}
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("B");
}
else if (grade >= 85 && grade <= 100)
{
    Console.WriteLine("A - Good Job");
}

/*
 * Write a program to accept an integer as the day of the week and printt the appropriate 
 * message as outlined below.
 * 
 * 1 - Sunday
 * 2 - Monday
 * 3 - Tuesday 
 * 4 - Wednesday (Hump Day!)
 * 5 - Thursday 
 * 6 - Friday (TGIF!!!)
 * 7 - Saturday (Beach Day!!!)
 * 
 */

Console.WriteLine("Please enter 1 - 7 to show the day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.WriteLine("Invalid Input!");
}
else if (day == 1)
{
    Console.WriteLine("Sunday");
}
else if (day == 2)
{
    Console.WriteLine("Monday");
}
else if (day == 3)
{
    Console.WriteLine("Tuesday");
}
else if (day == 4)
{
    Console.WriteLine("Wednesday (Hump Day!)");
}
else if (day == 5)
{
    Console.WriteLine("Thursday");
}
else if (day == 6)
{
    Console.WriteLine("Friday (TGIF!!");
}
else if (day == 7)
{
    Console.WriteLine("Saturday (Beach Day!!!)");
}

int gradeAfterBonus = grade >= 0 && grade <= 100 ? grade + 10 : 0;


Console.WriteLine("******************* Complex IF..Else IF  End *******************");

// Ternary operator - Used to assign a value to a variable based on a condition.
Console.WriteLine("******************* Ternary Operator Result *******************");

string passStatus = grade > 50 ? "Pass" : "Fail";
Console.WriteLine($"Student Status is: {passStatus}");

Console.WriteLine("******************* Ternary Operator Result End *******************");


Console.WriteLine("******************* Switch Statement Results  *******************");


/*
 * Write a program to accept an integer as the day of the week and printt the appropriate 
 * message as outlined below.
 * 
 * 1 - Sunday
 * 2 - Monday
 * 3 - Tuesday 
 * 4 - Wednesday (Hump Day!)
 * 5 - Thursday 
 * 6 - Friday (TGIF!!!)
 * 7 - Saturday (Beach Day!!!)
 * 
 */
Console.Write("Please enter the day of the week: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());

switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday (Hump Day!)");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday (TGIF!!!)");
        break;
    case 7:
        Console.WriteLine("Saturday (Beach Day!)");
        break;
    default:
        Console.WriteLine("Input invalid");
        break;
}



Console.WriteLine("******************* Switch Statement End  *******************");

// The rest of the application
Console.WriteLine("Thank you for using this program");
