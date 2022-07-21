using System;
namespace ChooseYourPath
{

    public static class MainMenu
    {
        public static void Menu()
        {

            int opt;

            while (true)

            {
                Console.Write(" At any time, you can use these options:");
                Console.Write(" 1)- Display Name");
                Console.Write(" 2)- Display Email");
                Console.Write(" 3)- Display Runtime");
                Console.Write(" 4)- Export Path");
                Console.Write(" 5)- Exit");
                Console.Write("  -Choose an option or press 6 then hit Enter to continue. ");



                opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.Write("Your name is " + Program.UserName + ".");
                        break;

                    case 2:
                        Console.Write("Your email is " + Program.UserEmail + ".");
                        break;

                    case 3:
                        Console.Write("Your runtime is " + ".");
                        break;

                    case 4:
                        Console.WriteLine("Your path is being exported.");
                        break;

                    case 5:
                        Environment.Exit(5);
                        break;

                    case 6:
                        Console.Clear();
                        Game.GameStart();
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }

}

