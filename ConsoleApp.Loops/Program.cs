//Console.WriteLine("Hello, World!");

// Simple For Loop Demo
// Print Hello World 10 times
Console.WriteLine("****************** Simple For Loop ******************");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello, World! - {i}");
}

//Console.WriteLine("Loop Completed!");
//Console.WriteLine("");

// Ask User how many times they wish to print hello world and print accordingly
//Console.Write("Please enter the number of times you would like to print \"Hello World\": ");
//int numberOfTimes = Convert.ToInt32(Console.ReadLine());

//for(int i = 0; i < numberOfTimes; i++)
//{
//    Console.WriteLine($"Hello World! - Iteration {i + 1}");
//}

//Console.WriteLine("Thank you for using this program!");

Console.WriteLine("****************** Simple For Loop Completed ******************");
Console.WriteLine("");
Console.WriteLine("");

// While Loop
Console.WriteLine("****************** Simple While Loop ******************");

int counter = 0;

while(counter < 10)
{
    Console.WriteLine($"Hello World! - Iteration{counter}");
    counter += 2;
}

// Ask the user for a number and find the total for each number that is entered. Print final sum when the used enterrs -1 to exit.

int userCounter = 0;
int sum = 0;
while (userCounter != -1)
{
    Console.Write("Please enter any number to sum or enter -1 to stop or exit: ");
    userCounter = Convert.ToInt32(Console.ReadLine());
    // nested if statement
    if (userCounter != -1)
    {
        sum += userCounter;
    }
}

Console.WriteLine($"The Sum of All Numbers Given is: {sum}");

Console.WriteLine("****************** Simple While Loop Completed ******************");
Console.WriteLine();

Console.WriteLine("****************** Simple Do While Loop ******************");
sum = 0;
userCounter = 0;

do
{
    Console.Write("Please enter any number to sum or enter -1 to stop or exit: ");
    userCounter = Convert.ToInt32(Console.ReadLine());
    // nested if statement
    if (userCounter != -1)
    {
        sum += userCounter;
    }
} while (userCounter != -1);
Console.WriteLine("****************** Simple Do While Loop Completed ******************");
