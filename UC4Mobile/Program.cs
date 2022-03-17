using System;
namespace UC4Mobile;
class Program
{
    public static void Main(string[] args)
    {

        string Mobile = Console.ReadLine();
        UC4 mobile= new UC4();



        bool match = mobile.validateMobile(Mobile);

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