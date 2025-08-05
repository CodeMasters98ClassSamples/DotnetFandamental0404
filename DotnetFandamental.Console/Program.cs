namespace DotnetFandamental;

internal class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        string fullName = firstName + " " + lastName;

        lastName = lastName + 2;

        Console.WriteLine("Thank you! (From Github)" + fullName);

        Console.WriteLine("What is your national code?");
        string nationalCode = Console.ReadLine();
    }
}
