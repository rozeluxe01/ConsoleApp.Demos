// Different datatypes
/*
 
    text - string
    integers - int
    decimal - double, float, decimal
    logical - bool
 
 */


string name = "Kevin George Buhain";

Console.WriteLine("I am " + name); // String concatenation
Console.WriteLine($"I am {name}"); // String interpolation
Console.WriteLine("They call me Kevin or George");
Console.WriteLine("I was given the name {0}", name); // String formatting - the {0} is a placeholder for the variable 'name'

int age = 54;
int retirementYearsLeft = 11;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine("My age is: " + age);

Console.WriteLine("My retirement age is: " + retirementAge);

bool isRetired = false;