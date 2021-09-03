using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace LMS.BAL.Validations
{
    static class RegisterValidation
    {
        public static bool CheckPassword(string Password, string Re_Password)
        {
            if (Password.Equals(Re_Password))
            {
                return true;
            }
            else
                return false;
        }
        public static bool ValidatePassword(string Password)
        {
            string pattern = @"^(?=.[0-9])(?=.[a-z])(?=.[A-Z])(?=.[@#$%&*]).{8,15}";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(Password))
            {
                return true;
            }
            else
                return false;
        }
    }
}