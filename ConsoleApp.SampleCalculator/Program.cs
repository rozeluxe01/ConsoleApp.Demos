// Welcome Message
Console.WriteLine("********************* Welcome to the Sample Calculator *********************");



/*
 * Math Operations and operators
 */
// Variable Decalarations
int choice = 0;
int num1 = 0, num2 = 0;

// Prompt for user input


while (choice != -1)
{
    try
    {

        // Show calculator options / Show menu
        Console.Clear();
        Console.WriteLine("Please select an operation (-1 to exit program)");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Fibonacci Sequence");
        //Console.WriteLine("5. Modulus");
        
        choice = Convert.ToInt32(Console.ReadLine());
        
        


        if (choice == -1)
        {
            break;
        }

        if(choice < 6)
        {
            Console.Write("Please enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the seecond number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        
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
                throw new Exception("Invalid Menu Item Selected.");
        }

        // print output
        Console.WriteLine($"The result is: {answer}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        
    }
    finally
    {
        Console.WriteLine("press any key to continue.");
        Console.ReadLine();
    }


}

Console.WriteLine("Thank you for using the sample calculator program!");

