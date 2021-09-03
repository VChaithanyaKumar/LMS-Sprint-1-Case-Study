using System;
using LMS.DAL;
using LMS.BAL.Validations;
using LearningManagementSystem.Entities;
namespace LMS.BAL
{
    //Registration-- Josy George
    public class RegisterService
    {
        //object reference for RegisterRepository
        private RegisterRepository register = null;
        string Re_Password;
        public RegisterService(User user, string Re_Password)
        {
            this.Re_Password = Re_Password;
            register = new RegisterRepository();
        }
        //invoking AddUser from the RegisterRepository
        
        public string RegisterUser(User user)
        {
            if (RegisterValidation.ValidatePassword(user.UserPassword)!=true)
            {
                return "A password must the Conditions.\n 1. Length should be between [8-15] \n 2. contains a Uppercase and a lower case Character \n 3. contains a number\nPlease Try Again.";  
            }
            if (RegisterValidation.CheckPassword(user.UserPassword, Re_Password))
            {

                register.AddingUser(user);
                return "SucessfullyAdded!";
            }
            else
                return "Password missmatch!";

        }

    }
}
