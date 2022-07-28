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
            GameLog.GameLogger();
            String line;

            try
            {
                StreamReader sr = new StreamReader(@"../../../Story/Intro.txt");
                line = sr.ReadLine();
                while (line != null)
                {

                    Console.WriteLine(line);

                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            
            //Intro First Choice

            IntroChoice = Console.ReadLine();

            using StreamWriter sw = File.AppendText(@"gamelogger.txt");
            {
                sw.WriteLine(IntroChoice);
            }

            if (IntroChoice == "loss")
            {
                StreamReader sl = new StreamReader(@"../../../Story/IntroChoiceLoss.txt");
                line = sl.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sl.ReadLine();
                }
                sl.Close();
                
            }

            else
                {
                    StreamReader sd = new StreamReader(@"../../../Story/IntroChoiceDread.txt");
                    line = sd.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = sd.ReadLine();
                    }
                    sd.Close();
                }
            }
        



            //Map

            
        }



        
    }
    


