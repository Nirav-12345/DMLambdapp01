using System;
using System.Text.RegularExpressions;
namespace UC2LastName;
class Program
{
    public static void Main(string[] args)
    {
        string Lastname = Console.ReadLine();
        UC2 v = new UC2();

        bool match = v.validateName(Lastname);

        if(match)
        {
            try
            {
                Console.WriteLine(true);
            }

            catch(ExecutionEngineException e)
            {
                Console.WriteLine(e.InnerException);
            }
        }


    }
}
