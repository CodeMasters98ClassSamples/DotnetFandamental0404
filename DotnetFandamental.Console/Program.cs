namespace DotnetFandamental;

internal class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter index of day?");
        short ind = short.Parse(Console.ReadLine());

        string discountCode = "";
        switch (ind)
        {
            case 5:
                discountCode = Guid.NewGuid().ToString();
                break;
            case 6:
                discountCode = Guid.NewGuid().ToString();
                break;
        }
        Console.WriteLine(discountCode);




        Console.WriteLine("Age?");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your gender?(M-> Men, F -> Female)");
        string gender = Console.ReadLine();

        if (age > 25 && gender == "M")
        {
            //Code
        }
        else if (age > 18 && gender == "F")
        {
            //Code
        }
        Console.WriteLine("Age?");
        if (gender == "M")
            age = int.Parse(Console.ReadLine());
        Console.WriteLine("Age: " + age);
        Console.WriteLine($"Age: {age}");

        Console.WriteLine("Please enter first number!");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second number!");
        int num2 = int.Parse(Console.ReadLine());
        //M -> men , F-> ..

        if (num1 > num2) //-> true
        {
            Console.WriteLine("Num1 is bigger than num2");
        }
        else
        {
            Console.WriteLine("Num2 is bigger than num1");
        }

        Console.WriteLine($"{num2} / {num1} is {num2 / num1}");
        Console.WriteLine(num2 + num1);
        Console.WriteLine(num2 * num1);
        Console.WriteLine(num2 % num1);





        //Type name = intitialValue;

        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();


        //Smaller to bigger
        //int num1 = 123;
        //long lng1 = num1;

        //long lng2 = 123;
        //int num2 = (int)lng2;

        string fullName = firstName + " " + lastName;

        lastName = lastName + 2;

        Console.WriteLine("Thank you! (From Github)" + fullName);

        Console.WriteLine("What is your national code?");
        string nationalCode = Console.ReadLine();
    }
}
