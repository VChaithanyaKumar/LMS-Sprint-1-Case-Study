using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BAL.Validations
{
    class LoginValidation
    {
        public static bool CheckPassword(string DbPassword, string UserPassword)
        {
            if (DbPassword.Equals(UserPassword))
            {
                return true;
            }
            else
                return false;
        }
        public static bool CheckUserName(string DbUserName, string UserName)
        {
            if (DbUserName.Equals(UserName))
            {
                return true;
            }
            else
                return false;
        }
        public static bool CheckUserType(string DbUserType, string UserType)
        {
            if (DbUserType.Equals(UserType))
            {
                return true;
            }
            else
                return false;
        }
    }
}
