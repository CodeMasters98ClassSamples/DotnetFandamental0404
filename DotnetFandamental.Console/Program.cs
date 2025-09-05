using DotnetFandamental.Enums;
using DotnetFandamental.Models;
using System.ComponentModel;

namespace DotnetFandamental;

internal class Program
{
    public static string FormatPhoneNumber(string phoneNumber)
    {
        //اگر 10 کارکتر بود و همچنین با صفر شروع نشده بود باید یک صفر به اول رشته اضافه کنید
        string FormatedPhoneNumber = "";
        try
        {
            if (phoneNumber.Length == 10 && !phoneNumber.StartsWith('0'))
            {
                phoneNumber = "0" + phoneNumber;
            }
            FormatedPhoneNumber = phoneNumber.Replace("+98", "0");

            return FormatedPhoneNumber;
        }
        catch (Exception ex)
        {

        }
        return FormatedPhoneNumber;
    }

    public static void ShowWellcomeMessage(string firstName = "", string lastName = "")
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
        int result = Sum(num1, num2);
        return (result + num3);
    }

    public static bool IsValidPhoneNumber(string input)
    {

        if (input == null)
        {
            return false;
        }
        if (input.Length != 11) //"aaaaaaaaaaa"
            return false;
        else
            return true;
    }

    public static bool IsValidGenderInput(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length > 1)
            return false;
        if (input.ToLower() == "m" || input.ToLower() == "f")
            return false;
        else
            return true;
    }

    static void Main(string[] args)
    {
        
        Student[] students = new Student[20];

        //DataType Name;
        Student student = new Student(); //Shape 1

        Console.WriteLine("Please eneter your gender?{M: Men, F: Female}");
        string genderStr = Console.ReadLine() ?? string.Empty;
        if (genderStr.ToUpper() == "M")
        {
            student.Gender = Gender.MALE;
        }
        else if (genderStr.ToUpper() == "F")
        {
            student.Gender = Gender.FEMALE;
        }
        else
        {

        }


        do
        {
            System.Console.WriteLine("What is your first name?");
            student.FirstName = System.Console.ReadLine() ?? string.Empty;
            if (!string.IsNullOrEmpty(student.FirstName) && student.FirstName.Length > 2)
                break;
            else
                Console.WriteLine("You entered invalid data!");
        } while (true);


        while (true)
        {
            Console.WriteLine("What is your last name?");
            student.LastName = Console.ReadLine() ?? string.Empty;
            if (!string.IsNullOrEmpty(student.LastName) && student.LastName.Length > 2)
                break;
            else
                Console.WriteLine("You entered invalid data!");
        }

        ShowWellcomeMessage(firstName: student.FirstName, lastName: student.LastName);

        Console.WriteLine("Please enter your phone number?");
        for (; ; )
        {
            try
            {
                student.PhoneNumber = Console.ReadLine() ?? throw new Exception("Invalid PhoneNumber!");
                if (IsValidPhoneNumber(student.PhoneNumber))
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
        student.Age = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your gender?(M-> Men, F -> Female)");
        string gender = Console.ReadLine();

        Console.WriteLine("Thank you! (From Github)" + student.FullName);

        Console.WriteLine("What is your national code?");
        string nationalCode = Console.ReadLine();


    }
}
