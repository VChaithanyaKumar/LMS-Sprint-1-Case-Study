using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}