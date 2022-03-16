using System;
using System.Text.RegularExpressions;
namespace UC4MobileFormat;
class Program
{
    public static void Main(string[] args)
    {







        List<MobileFormat> listperson = new List<MobileFormat>();

        listperson.Add(new MobileFormat(7585853052));

        string s = "^[1-9]{2}[0-9]{10}";
        try
        {
            foreach (MobileFormat uC1Lambda in listperson.FindAll(e => e.Mobileformat == 7585853052))
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
