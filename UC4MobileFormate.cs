using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UC4MobileFormate
    {
        public static string REGEX_MobileNo = "^[0-9]{1,3}[ ][6789][0-9]{9}$"; // 91 9919819801

        public bool ValidateMobileNo(string MobileNo)
        {
            return Regex.IsMatch(MobileNo, REGEX_MobileNo);
        }
    }
}
