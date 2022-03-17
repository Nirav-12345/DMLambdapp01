using System;
namespace UC8SpecialLambda;
class Program
{
    public static void Main(string[] args)
    {

        string Special = Console.ReadLine();
        UC8 special = new UC8();



        bool match = special.validateName(Special);

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