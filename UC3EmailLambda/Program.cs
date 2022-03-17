using System;
namespace UC3EmailLambda;
class Program
{
    public static void Main(string[] args)
    {

        string Email = Console.ReadLine();
        UC3Em email = new UC3Em();



        bool match = email.validateEmail(Email);

        if (match)
        {
            try
            {
                Console.WriteLine(true);
            }

            catch (ExecutionEngineException e)
            {
                Console.WriteLine(e.InnerException);
            }
        }
    }
}