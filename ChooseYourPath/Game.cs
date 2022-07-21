using System.IO;
using System.Text;

namespace ChooseYourPath
{
    public static class Game
    {
        static bool Run = true;
        static int Choice;
        static bool Goal = false;
        static int Scenarios = 2;
        static List<string> Inventory = new List<string>();
        private static string? IntroChoice;

        public static void GameStart()
        {
            String line;

            try
            {
                StreamReader sr = new StreamReader(@"Intro.txt");
                line = sr.ReadLine();
                while (line != null)
                {

                    Console.WriteLine(line);

                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            IntroChoice = Console.ReadLine();

            if (IntroChoice == "loss")
            {
                StreamReader sr = new StreamReader(@"IntroChoiceLoss.txt");
                line = sr.ReadLine();
                while (line != null)
                {

                    Console.WriteLine(line);

                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }

            else _ = IntroChoice == "dread";
            {
                StreamReader sr = new StreamReader(@"IntroChoiceDread.txt");
                line = sr.ReadLine();
                while (line != null)
                {

                    Console.WriteLine(line);

                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }

        }



        
    }
    
}

