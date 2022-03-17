using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UC4Mobile
{
    public class UC4
    {
        public static string s = "^[1-9]{2}[0-9]{10}";

        public bool validateMobile(string name)
        {
            return Regex.IsMatch(name, s);
        }


    }
}
