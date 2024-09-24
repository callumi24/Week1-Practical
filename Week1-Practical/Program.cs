// Calculating age in 5 years
Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

Console.WriteLine("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age <= 0 || age >= 110)
{
    Console.WriteLine("Invalid age.");
}

Console.WriteLine("Hello " + name + ", you will be " + (age + 5) + " years old in 5 years!");

// Calculates whether or not this year is a leap year
Console.WriteLine("Enter a year (for example, 2024).");
int year = Convert.ToInt32(Console.ReadLine());

if (year <= 0)
{
    Console.WriteLine("This number is negative.");
}

if (year % 4 == 0 && year % 100 != 0)
{
    Console.WriteLine("The year " + year + " is a leap year!");
}

// Determines whether this number is even or odd
Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("The number " + num + " is an even number.");
}
else
{
    Console.WriteLine("The number " + num + " is an odd number.");
}
