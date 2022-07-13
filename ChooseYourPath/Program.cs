using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Globalization;

namespace ChooseYourPath
{
    public class Program
    {
        private static string? userName;
        private static string? userEmail;
        private static string email;

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Hill Cavern Fair.");

            Console.WriteLine("Please enter your name:");

            userName = Console.ReadLine();

            Console.WriteLine("Please enter your email address:");

            userEmail = Console.ReadLine();
            {

                if (RegexEmail.RegexEmailValid.IsValidEmail(email, userEmail) != true)
                {
                    Console.WriteLine("Please enter a valid email.");
                    userEmail = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Thank you. Your name is " + userName + " and your email is "
                        + userEmail + ". Enjoy your visit.");
                }
            }
        }

    }
}