using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

/*
Rule2 – Should have at least 1 Upper Case
*/

namespace UserRegistration
{
    public class UC6Password
    {
        public static string REGEX_Password2 = "^[A-Z]{1}[A-Z a-z]{7,}$"; 

        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_Password2);
        }
    }
}

