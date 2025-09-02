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
        string firstName = string.Empty;
        string lastName = string.Empty;

        do
        {
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine() ?? string.Empty;
            if (!string.IsNullOrEmpty(firstName) && firstName.Length > 2)
                break;
            else
                Console.WriteLine("You entered invalid data!");
        } while (true);


        while (true)
        {
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine() ?? string.Empty;
            if (!string.IsNullOrEmpty(lastName) && lastName.Length > 2)
                break;
            else
                Console.WriteLine("You entered invalid data!");
        }

        ShowWellcomeMessage(firstName: firstName, lastName: lastName);

        Console.WriteLine("Please enter your phone number?");
        for (;;)
        {
            try
            {
                string phoneNumber = Console.ReadLine() ?? throw new Exception("Invalid PhoneNumber!");
                if (IsValidPhoneNumber(phoneNumber))
                    break;
                else
                    Console.WriteLine("You entered invalid data!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("You entered invalid data!");
                continue;
            }   
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
