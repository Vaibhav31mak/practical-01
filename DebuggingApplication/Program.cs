Console.Write("Please Enter a Something: ");
string userResponse = Console.ReadLine()!;
if (Convert.ToBoolean(int.Parse(userResponse)))
{
    Console.WriteLine("The entered value is a integer");
}