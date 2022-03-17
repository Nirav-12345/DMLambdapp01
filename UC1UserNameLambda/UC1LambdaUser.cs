using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UC1UserNameLambda
{
    public class UC1
    {



        public static string s = "[A-Z]{1}[A-Za-z]{2}$";
        public bool validateName(string name)
        {
            return Regex.IsMatch(name, s);
        }

    }


















}

    


    



    
            


        
            







    

