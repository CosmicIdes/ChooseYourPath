using System;
namespace ChooseYourPath
{
    public class GameEnd
    {
        public static void GameEndOptions()
        {
            int opt;

            do

            {
                Console.Write(" 1)- Display Runtime");
                Console.Write(" 2)- Display Inventory");
                Console.Write(" 3)- Go to Park Map");
                Console.Write(" 4)- Exit");

                opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.Write("Your runtime is " + Runtime.CurrentRuntime / 1000 + " seconds.");
                        break;

                    case 2:
                        Console.WriteLine("You have:");
                        foreach (string item in Game.Inventory)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 3:
                        Game.ParkMap();
                        break;

                    case 4:
                        Environment.Exit(5);
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            } while (true);
        }
    }
}
