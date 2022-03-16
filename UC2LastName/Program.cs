using System;
using System.Text.RegularExpressions;
namespace UC2LastName;
class Program
{
    public static void Main(string[] args)
    {







        List<UC2> listperson = new List<UC2>();

        listperson.Add(new UC2("Raj"));

        string s = "^[A-Z]{1}[A-Za-z]{2}$";
        try
        {
            foreach (UC2 uC1Lambda in listperson.FindAll(e => e.LastName == "Raj"))
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
