using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UC2LastName
    {
        public static string LAST_NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";

        public bool ValidateFirstName(string lName)
        {
            return Regex.IsMatch(lName, LAST_NAME_REGEX);
        }
    }
}
