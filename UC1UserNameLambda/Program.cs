using System;
using System.Text.RegularExpressions;
namespace UC1UserNameLambda;
class Program
{
    public static void Main(string[] args)
    {


        string name = Console.ReadLine();
        UC1 v = new UC1();

        bool match = v.validateName(name);

        if(match)
        {
            try
            {
                Console.WriteLine(true);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}

















    
    
        

