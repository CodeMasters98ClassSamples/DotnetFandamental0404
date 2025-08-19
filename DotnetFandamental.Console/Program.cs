namespace DotnetFandamental;

internal class Program
{

    public static string FormatPhoneNumber(string phoneNumber)
    {
        //اگر 10 کارکتر بود و همچنین با صفر شروع نشده بود باید یک صفر به اول رشته اضافه کنید
        if (phoneNumber.Length == 10 && !phoneNumber.StartsWith('0'))
        {
            phoneNumber = "0" + phoneNumber;
        }
        string FormatedPhoneNumber = phoneNumber.Replace("+98", "0");
        
        return FormatedPhoneNumber;
    }

    public static void ShowWellcomeMessage(string firstName = "",string lastName = "")
    {
        Console.WriteLine($"Wellcome {firstName} {lastName} to csharp");
    }

    //Method OverLoad
    public static int Sum(int num1, int num2)
    {
        if (num1 > 1)
        {
            //
        }
        return (num1 + num2);
    }

    public static int Sum(int num1, int num2, int num3)
    {
        int result = Sum(num1 , num2);
        return (result + num3);
    }

    public static bool IsValidPhoneNumber(string input)
    {

        if (input == null) { 
            return false;
        }
        if (input.Length != 11) //"aaaaaaaaaaa"
            return false;
        else
            return true;
    }

    static void Main(string[] args)
    {
        int x = 1;
        ShowWellcomeMessage();

        Console.WriteLine("inp1?");
        int inp1 = int.Parse(Console.ReadLine());

        Console.WriteLine("inp2?");
        int inp2 = int.Parse(Console.ReadLine());


        int result = Sum(num1: inp2, num2: inp1); //Call a method
        Console.WriteLine("Sum is: " + result);

        Console.WriteLine("Please enter your phone number?");
        string phoneNumber = Console.ReadLine();
        //Code
        if (IsValidPhoneNumber(phoneNumber))
        {
            Console.WriteLine("Please eneter valid phone number");
        }

        Console.WriteLine("Please enter your another phone number?");
        string anotherPhoneNumber = Console.ReadLine();
        //Code
        if (IsValidPhoneNumber(anotherPhoneNumber))
        {
            Console.WriteLine("Please eneter valid phone number");
        }


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
