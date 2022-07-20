/* Welcome to Hill Cavern Fair, an adventure game.
    * Coding: OrenjiId3s (https://github.com/OrenjiId3s/ChooseYourPath)
    * Story: Calliope Woods (http://www.calliopewoods.com/)*/

using System.Diagnostics;
using System.IO;

namespace ChooseYourPath

{
    public class Program
    {
        public static void GameLog()
        {
            StreamWriter logFile = File.CreateText("gamechoices.log");
            Trace.Listeners.Add(new TextWriterTraceListener(logFile));
            Trace.AutoFlush = true;
            Trace.WriteLine("Starting Game Log");
            Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
        }

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

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("[Game would be here]");
            Console.ReadKey();
        }

        static void Write(string message)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            Console.ResetColor();

            Console.WriteLine("Hello! Welcome to Hill Cavern Fair.");

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
            Console.WriteLine("At any time, you can enter from these options:");
            Console.WriteLine("Display Name");
            Console.WriteLine("Display Email");
            Console.WriteLine("Display Runtime");
            Console.WriteLine("Export Path");
            Console.WriteLine("Exit");
            Console.WriteLine("Choose an option or press Enter to continue");

            Console.ReadLine();

            Console.Clear();



        



    }

}
   
}