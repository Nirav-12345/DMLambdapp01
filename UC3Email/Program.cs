using System;
using System.Text.RegularExpressions;
namespace UC3Email;
class Program
{
    public static void Main(string[] args)
    {







        List<Email> listperson = new List<Email>();
        string s = "^[A-Za-z0-9]{3,20}@gmail.com$";
        listperson.Add(new Email("Raj@gmail.com"));

        
        try
        {
            foreach (Email uC1Lambda in listperson.FindAll(e => e.Gmail == "Raj"))
            {
                Console.WriteLine(true);
            }

        }

        catch (AccessViolationException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
