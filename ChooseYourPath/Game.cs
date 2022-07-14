using System;
namespace ChooseYourPath
{
    public static class Game

    {
        public static void StartGame()
        { }


        private static string? userName;
        private static string? userEmail;
        private static string email = "test@test.com";

        public static string? UserName { get => userName; set => userName = value; }
        public static string? UserEmail { get => userEmail; set => userEmail = value; }
        public static string Email { get => email; set => email = value; }

        public static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            string TitleText = "";
            TitleText = @"
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


                                                   
               Code by OrenjiId3s
             Story by Calliope Woods                    
               (press enter to play)               
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
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        
            Console.WriteLine("Hello! Welcome to Hill Cavern Fair.");

            Console.WriteLine("Please enter your name:");

            UserName = Console.ReadLine();

            Console.WriteLine("Please enter your email address:");

            UserEmail = Console.ReadLine();
            {

                if (RegexEmail.RegexEmailValid.IsValidEmail(Email, UserEmail) != true)
                {
                    Console.WriteLine("Please enter a valid email.");
                    UserEmail = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Thank you. Your name is " + UserName + " and your email is "
                        + UserEmail + ". Enjoy your visit.");
                }
            }
            Console.WriteLine("At any time, you can enter from these options:");
            Console.WriteLine("Display Name");
            Console.WriteLine("Display Email");
            Console.WriteLine("Display Runtime");
            Console.WriteLine("Export Path");
            Console.WriteLine("Exit");
        }

        
        
    }
}

