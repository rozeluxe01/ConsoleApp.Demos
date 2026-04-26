

Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

/*
    Math Operations and operators
 */

// Add numbers
int sum = (int)(num1 + num2);

// Subtract numbers
int difference = num1 - num2;

// Multiply numbers
int product = num1 * num2;

// Divide numbers
int quotient = num1 / num2;

// Modulus (remainder of the operation ex. (5 % 2) = 1)
int mod = num1 % num2;

Console.WriteLine("******************** Math Results *******************");
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Modulus: {mod}");
Console.WriteLine();

Console.WriteLine("******************** End Math Results *******************");


/*
    Logic Operations and Operators
 
 */


bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("******************** Logic Results *******************");
Console.WriteLine();
Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Equal To: {isEqualTo}");
Console.WriteLine($"Is Greater Than or Equal To: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than or Equal To: {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal: {isNotEqual}");
Console.WriteLine();
Console.WriteLine("******************** End Logic Results *******************");


/*
    Assignment Operations and Operators
 
 */
Console.Write("Please enter a third number for Assignment Operations: ");
int randomValue = Convert.ToInt32(Console.ReadLine());

//int increaseValue = num1 + 5;

//num1 = num1 + 5;

Console.WriteLine("******************** Assignment Results *******************");
Console.WriteLine();
num1 += randomValue;
Console.WriteLine($"Num 1 is increased by {randomValue}: {num1}");
num1 -= randomValue;
Console.WriteLine($"Num 1 is reduced by {randomValue}: {num1}");
num1 /= randomValue;
Console.WriteLine($"Num 1 is divided by {randomValue}: {num1}");
num1 %= randomValue;
Console.WriteLine($"Num 1 is mod by {randomValue}: {num1}");
num1 *= randomValue;
Console.WriteLine($"Num 1 is multiplied by {randomValue}: {num1}");
Console.WriteLine();
Console.WriteLine("******************** End Assignment Results *******************");

