using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UC1FirstName
    {
        public static string FIRST_NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";

        public bool ValidateFirstName(string fName)
        {
            return Regex.IsMatch(fName, FIRST_NAME_REGEX);
        }
    }
}
