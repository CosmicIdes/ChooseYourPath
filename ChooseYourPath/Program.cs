using System;

using System.IO;

using System.Text.RegularExpressions;


namespace ChooseYourPath
{
    public class Program
    {
        private static string? userName;
        private static string? userEmail;
        private static object? txtEmail;

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Hill Cavern Fair.");

            Console.WriteLine("Please enter your name:");

            userName = Console.ReadLine();

            Console.WriteLine("Please enter your email address:");

            userEmail = Console.ReadLine();

            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(txtEmail.Text.Trim());
               if (!isValid)
               {
                   Console.WriteLine("Invalid Email.");
               }
            

            Console.WriteLine("Thank you. Your name is " + userName + " and your email is "
                + userEmail + ". Enjoy your visit.");

            
        }
        
    }
}