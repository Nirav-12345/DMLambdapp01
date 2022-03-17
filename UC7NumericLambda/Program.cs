using System;
namespace UC7NumericLambda;
class Program
{
    public static void Main(string[] args)
    {

        string NumC = Console.ReadLine();
        UC7 numc = new UC7();



        bool match =numc.validateName(NumC);

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