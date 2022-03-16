using System;
using System.Text.RegularExpressions;
namespace UC1UserNameLambda;
class Program
{
    public static void Main(string[] args)
    {
        
        
            
            



            List<UC1LambdaUser> listperson = new List<UC1LambdaUser>();

            listperson.Add(new UC1LambdaUser("Nir"));

            string s = "[A-Z]{1}[A-Za-z]{2}$";
        try
        {
            foreach (UC1LambdaUser uC1Lambda in listperson.FindAll(e => e.FirstName == "nir"))
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