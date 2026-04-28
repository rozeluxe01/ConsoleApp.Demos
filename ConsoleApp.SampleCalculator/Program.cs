
// Welcome Message
Console.WriteLine("********************* Welcome to the Sample Calculator *********************");



/*
 * Math Operations and operators
 */

// Show calculator options / Show menu
Console.WriteLine("Please select an operation (-1 to exit program)");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Fibonacci Sequence");
//Console.WriteLine("5. Modulus");

// Prompt for user input
int choice = Convert.ToInt32(Console.ReadLine());

while (choice != -1)
{
    Console.Write("Please enter the first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Please enter the seecond number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());



    // Decide which operation is needed based on selected option

    //if(choice == 1)
    //{
    //    /* do addition */
    //}
    //else if(choice == 2)
    //{
    //    /* Subtraction */
    //}
    //else if (choice == 2)
    //{
    //    /* Multiplication */
    //}
    //else if (choice == 2)
    //{
    //    /* Division */
    //}
    //else
    //{
    //    Console.WriteLine("Invalid Choice");
    //}

    /* Switch statment */
    int answer = 0;
    switch (choice)
    {
        case 1:
            /* Addition */
            answer = num1 + num2;
            break;
        case 2:
            /* Subtraction */
            answer = num1 - num2;
            break;
        case 3:
            /* Multiplication */
            answer = num1 * num2;
            break;
        case 4:
            /* Division */
            answer = num1 / num2;
            break;
        case 5:
            for (int i = num1; i <= num2; i++)
            {
                answer += i;
            }
            break;
        default:
            Console.WriteLine("Invalid Choice");
            break;
    }

    // print output
    Console.WriteLine($"The result is: {answer}");
    Console.WriteLine($"Press Enter to continue");
    Console.ReadLine();

    // Show calculator options / Show menu
    Console.WriteLine("Please select an operation (-1 to exit program)");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci Sequence");
    //Console.WriteLine("5. Modulus");

    // Prompt for user input
    choice = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Thank you for using the sample calculator program!");

