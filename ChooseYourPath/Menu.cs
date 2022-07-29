namespace ChooseYourPath
{

    public static class MainMenu
    {
        public static void Menu()
        {
            int opt;

            do

            {
                Console.Write(" 1)- Display Name");
                Console.Write(" 2)- Display Email");
                Console.Write(" 3)- Display Runtime");
                Console.Write(" 4)- Exit");
                Console.Write("  -Choose an option or press 5 then hit Enter to continue to the game. ");



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
                        Console.Write("Your runtime is " + Runtime.CurrentRuntime / 1000 + " seconds.");
                        break;

                    case 4:
                        Environment.Exit(5);
                        break;

                    case 5:
                        Console.Clear();
                        Game.GameStart();
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            } while (true);
        }
    }

}

