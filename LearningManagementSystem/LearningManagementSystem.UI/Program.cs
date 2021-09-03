using System;
using LMS.BAL;
using LearningManagementSystem.Entities;
using System.IO;
namespace LearningManagementSystem.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RegisterService registerService = null;
                LoginService loginService = null;
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
                        case 1:
                            {

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
                                            user = new User();
                                            user.UserType = "Admin";
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
                                            user = new User();
                                            user.UserType = "Learner";
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
                        case 2:
                            {

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
                string ErrorMsg= string.Format($"Error Message:{e.Message} Date:{DateTime.Now} Class:Programe");
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(ErrorMsg);
                streamWriter.Close();
                fileStream.Close();

            }
        }
    }
}
