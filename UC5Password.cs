using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UC5Password
    {
        public static string REGEX_Password1 = "^[A-Z a-z]{8,}$"; //shubhamsth, ShubhamSth

        public bool ValidatePassword1(string password)
        {
            return Regex.IsMatch(password, REGEX_Password1);
        }
    }
}
