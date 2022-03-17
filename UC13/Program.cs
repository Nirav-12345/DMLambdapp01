using System;
namespace UC13;

class Program
{
    public static void Main(string[] args)
    {
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter the last name = ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter the email = ");
        string email = Console.ReadLine();
        Console.WriteLine("Enter the mobile pattern = ");
        string mobilePattern = Console.ReadLine();
        Console.WriteLine("Enter the password = ");
        string preDefinedPassword = Console.ReadLine();
        RegUC13 x = new RegUC13();
        Console.WriteLine(x.validateFirstName(firstName));
        Console.WriteLine(x.validateLastName(lastName));
        Console.WriteLine(x.validateEmail(email));
        Console.WriteLine(x.validateMobileFormat(mobilePattern));
        Console.WriteLine(x.validatePreDefinedPassword(preDefinedPassword));
    }
}