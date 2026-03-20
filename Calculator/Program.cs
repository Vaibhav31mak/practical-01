Console.WriteLine("This is a Calculator in which you will enter 2 numbers and the result will be obtained which would be the sum, subtraction, multiplication and division of the two numbers.");
// Enter First Number
Console.Write("Please Enter the First Number: ");
int FirstNumber;
while (!int.TryParse(Console.ReadLine(), out FirstNumber))
{
    Console.WriteLine("Not Entered a valid input. Please Enter a valid number as input.");
    Console.Write("Please Enter the First Number: ");
}
// Enter Second Number
Console.Write("Please Enter the Second Number: ");
int SecondNumber;
while (!int.TryParse(Console.ReadLine(), out SecondNumber))
{
    Console.WriteLine("Not Entered a valid input. Please Enter a valid number as input.");
    Console.Write("Please Enter the Second Number: ");
}

Console.WriteLine($"Addition of the {FirstNumber} and {SecondNumber} is {FirstNumber + SecondNumber}");
Console.WriteLine($"Subtraction of the {FirstNumber} and {SecondNumber} is {FirstNumber - SecondNumber}");
Console.WriteLine($"Product of the {FirstNumber} and {SecondNumber} is {FirstNumber * SecondNumber}");
try
{
    Console.WriteLine($"Division of the {FirstNumber} and {SecondNumber} is {FirstNumber / SecondNumber}");
}
catch(DivideByZeroException e)
{
    Console.WriteLine(e.Message+". Second Number should not be zero for division as it would give undefined output.");
}

Console.ReadKey();