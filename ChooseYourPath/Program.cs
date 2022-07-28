/* Welcome to Hill Cavern Fair, an adventure game.
    * Coding: OrenjiId3s (https://github.com/OrenjiId3s/ChooseYourPath)
    * Story: Calliope Woods (http://www.calliopewoods.com/)*/

using System.Diagnostics;
using System.IO;

namespace ChooseYourPath

{
    public class Program
    {

        private static string? userName;
        private static string? userEmail;

        public static string? UserName { get => userName; set => userName = value; }
        public static string? UserEmail { get => userEmail; set => userEmail = value; }

        public static void Main(string[] args)
        {

            Console.Clear();
            string TitleText = @"
                #     #                 
                #     # # #      #      
                #     # # #      #      
                ####### # #      #      
                #     # # #      #      
                #     # # #      #      
                #     # # ###### ###### 
                        
         #####                                     
        #     #   ##   #    # ###### #####  #    # 
        #        #  #  #    # #      #    # ##   # 
        #       #    # #    # #####  #    # # #  # 
        #       ###### #    # #      #####  #  # # 
        #     # #    #  #  #  #      #   #  #   ## 
         #####  #    #   ##   ###### #    # #    # 
                                           
                #######                 
                #         ##   # #####  
                #        #  #  # #    # 
                #####   #    # # #    # 
                #       ###### # #####  
                #       #    # # #   #  
                #       #    # # #    # 


                                                   
                Code by Brandi Hornbuckle
                Story by Calliope Woods                                  
";
            Console.Title = "Hill Cavern Fair";
            Write(TitleText);
        }
        
        static void Write(string message)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            Console.ResetColor();

            Console.WriteLine("Hello! Welcome to Hill Cavern Fair. This is best viewed in full screen mode.");

            Console.WriteLine("Please enter your name:");

            UserName = Console.ReadLine();

            Console.WriteLine("Please enter your email address:");

            UserEmail = Console.ReadLine();
            {

                if (RegexEmail.RegexEmail.Validate(UserEmail))

                {
                    Console.WriteLine("Thank you. Your name is " + UserName + " and your email is "
                        + UserEmail + ". Enjoy your visit.");
                }
                else
                {
                    Console.WriteLine("Please enter a valid email.");
                    UserEmail = Console.ReadLine();
                }
            }
            MainMenu.Menu();
            Game.GameStart();

    }

}
   
}