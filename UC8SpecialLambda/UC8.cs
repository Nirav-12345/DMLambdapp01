using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UC8SpecialLambda
{
    public class UC8
    {
        public static string s = "^[A-Z]{1}[a-z0-9]{6}[$&+,:;=?@#|'<>.^*()%!-]{1}$";
        public bool validateName(string name)
        {
            return Regex.IsMatch(name, s);
        }




    }
}
