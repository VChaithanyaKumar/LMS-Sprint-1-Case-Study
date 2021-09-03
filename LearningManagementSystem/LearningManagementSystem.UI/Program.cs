using System;
using LMS.BAL;//for accessing Business Layer 
using LearningManagementSystem.Entities;// for accessing Entity Objects
using System.IO;
namespace LearningManagementSystem.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //object reference for RegisterService
                RegisterService registerService = null;
                //object reference for LoginService
                LoginService loginService = null;
                //object reference for User
                User user = null;
                do
                {

                    Console.WriteLine("1. Existing User");
                    Console.WriteLine("2. New User");
                    Console.WriteLine("3. Exit");
                    Console.WriteLine("Enter your choice");
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        //if Existing User
                        case 1:
                            {
                                //getting user-type from the user
                                Console.WriteLine("1. Admin Login");
                                Console.WriteLine("2. Learner Login");
                                Console.WriteLine("3. Go Back");
                                Console.WriteLine("Enter your choice");
                                int ch1 = int.Parse(Console.ReadLine());
                                loginService = new LoginService();
                                switch (ch1)
                                {
                                    case 1:
                                        {
                                            //Admin user login
                                            user = new User();
                                            user.UserType = "Admin";
                                            //getting email and password from Admin
                                            Console.WriteLine("enter email");
                                            user.UserEmail = Console.ReadLine();
                                            Console.WriteLine("enter password");
                                            user.UserPassword = Console.ReadLine();
                                            string UserEmail = user.UserEmail;
                                            Console.WriteLine(loginService.LoginUser(user));
                                            break;
                                        }
                                    case 2:
                                        {
                                            //Learner user login
                                            user = new User();
                                            user.UserType = "Learner";
                                            //getting email and password from Learner
                                            Console.WriteLine("enter email");
                                            user.UserEmail = Console.ReadLine();
                                            Console.WriteLine("enter password");
                                            user.UserPassword = Console.ReadLine();
                                            string UserEmail = user.UserEmail;
                                            Console.WriteLine(loginService.LoginUser(user));
                                            break;
                                        }
                                    case 3:
                                        {
                                            continue;
                                        }
                                }

                                break;
                            }
                        //if new User
                        case 2:
                            {
                                //getting values from user
                                user = new User();
                                Console.WriteLine("Enter UserType");
                                user.UserType = Console.ReadLine();
                                Console.WriteLine("Enter first name");
                                user.UserFirstName = Console.ReadLine();
                                Console.WriteLine("Enter last name");
                                user.UserLastName = Console.ReadLine();
                                Console.WriteLine("Enter Gender");
                                user.Gender = char.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Email");
                                user.UserEmail = Console.ReadLine();
                                Console.WriteLine("Enter password");
                                user.UserPassword = Console.ReadLine();
                                Console.WriteLine("Retype Password");
                                string passwordRetype = Console.ReadLine();
                                registerService = new RegisterService(user, passwordRetype);
                                Console.WriteLine(registerService.RegisterUser(user));
                                break;
                            }
                        case 3:
                            {

                                return;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid choice");
                                break;
                            }
                    }
                } while (true);
            }
            catch (Exception e)
            {
                FileStream fileStream = new FileStream("G:\\MyCopyLMS\\LearningManagementSystem\\ErrorLog.txt", FileMode.OpenOrCreate);
                //Add exception details to ErrorLog.txt file.
                string ErrorMsg = string.Format($"Error Message:{e.Message} Date:{DateTime.Now} Class:Programe");
                //Add content to ErrorLog.txt file using StreamWriter.
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(ErrorMsg);
                streamWriter.Close();
                fileStream.Close();

            }
        }
    }
}