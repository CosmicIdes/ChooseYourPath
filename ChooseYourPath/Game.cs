using System.IO;
using System.Text;
using System.Collections.Generic;

namespace ChooseYourPath
{
    public static class Game
    { 
        static List<string> Inventory = new List<string>();
        private static string? IntroChoice;
        private static string? line;
        private static string? opt;

        public static void GameStart()
        {
            
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

            else if (IntroChoice == "dread")
                {
                    StreamReader sd = new StreamReader(@"../../../Story/IntroChoiceDread.txt");
                    line = sd.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = sd.ReadLine();
                    }
                    sd.Close();
                    Inventory.Add("Park Map");
                    Inventory.Add("Hill Cavern Fair Ticket");
                }
            ParkMap();
            }

        


        //Map
        public static void ParkMap()
       
        {

            while (true)

            {
                Console.Write("\r\nThe park map is as old and faded as everything else you’ve encountered. It lists several attractions:");
                Console.Write(" \r\nTrain Ride");
                Console.Write(" \r\nSnack Stand");
                Console.Write(" \r\nThe Grand Stage");
                Console.Write(" \r\nHill Cavern Petting Zoo");
                Console.Write(" \r\nHaunted House");
                Console.Write(" \r\nMerry-Go-Round");
                Console.Write(" \r\nYe Old Mill");
                Console.Write(" \r\nWhere would you like to go? ");


                opt = Console.ReadLine();

                switch (opt.ToLower())

                {
                    case "train ride":
                        StreamReader sr = new StreamReader(@"../../../Story/IntroChoiceLoss.txt");
                        line = sr.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line);
                            line = sr.ReadLine();
                        }
                        sr.Close();
                        break;

                    case "snack stand":
                        StreamReader ss = new StreamReader(@"../../../Story/SnackStandMain.txt");
                        line = ss.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line);
                            line = ss.ReadLine();
                        }
                        ss.Close();
                        string? SnackChoice = Console.ReadLine();
                        {
                            using StreamWriter sw = File.AppendText(@"gamelogger.txt");
                            sw.WriteLine(SnackChoice);
                        }

                        if (SnackChoice == "caramel corn")
                        {
                            Console.WriteLine("There are popcorn boxes behind the man that you assume are filled with caramel corn. They look dusty–are those spiderwebs? Even so, you feel a draw to the caramel corn. It feels like something worthwhile to have.");
                            Console.WriteLine("\r\nDo you want to order caramel corn? ");
                            string? CaramelCorn = Console.ReadLine();
                            if (CaramelCorn == "yes")
                            {
                                Inventory.Add("caramel corn");
                                Console.WriteLine("\r\nIt really only cost 25 cents. The box is dusty and cobwebby, but the caramel corn inside smells good, and when you eat some it’s satisfying, with a sweet crunch. You carry the box with you throughout the rest of the park. ");
                            }
                            else
                            {
                                goto case "snack stand";
                            }

                        }

                        else if (SnackChoice == "slushee")
                        {
                            Console.WriteLine("The slushee machine does not, in fact, look new. It looks as old and dusty as the rest of the place, and you question if it’s ever been cleaned in the however-many-years it’s been here. The frozen drink swirling inside is red, but the rim of the drink spout looks like it has some sort of black film on it–mold, or mildew.");
                            Console.WriteLine("\r\nDo you want to order a slushee? ");
                            string? Slushee = Console.ReadLine();
                            if (Slushee == "yes")
                                Console.WriteLine("It really was only 30 cents, but you have a feeling if you drank more than your initial sip your medical bills would be much more expensive. It tastes exactly like wet laundry forgotten in a washing machine smells. You throw the cup away as soon as you leave the snack stand. ");
                            else
                            {
                                Console.WriteLine("A good choice, really.");
                                goto case "snack stand";
                            }
                        }

                        else if (SnackChoice == "cotton candy")
                        {
                            Console.WriteLine("Bags of cotton candy hang off the ceiling of the snack stand. They look perfectly normal, and even relatively fresh, despite there being no cotton candy machine in sight.");
                            Console.WriteLine("\r\nDo you want to order cotton candy? ");
                            string? CottonCandy = Console.ReadLine();
                            if (CottonCandy == "yes")
                            {
                                StreamReader scy = new StreamReader(@"../../../Story/SnackStandCottonCandy.txt");
                                line = scy.ReadLine();
                                while (line != null)
                                {
                                    Console.WriteLine(line);
                                    line = scy.ReadLine();
                                }
                                scy.Close();
                            }
                            else
                            {
                                goto case "snack stand";
                            }
                        }

                        break;

                    case "the grand stage":
                        StreamReader sg = new StreamReader(@"../../../Story/IntroChoiceLoss.txt");
                        line = sg.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line);
                            line = sg.ReadLine();
                        }
                        sg.Close();
                        break;

                    case "hill cavern petting zoo":
                        StreamReader sz = new StreamReader(@"../../../Story/IntroChoiceLoss.txt");
                        line = sz.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line);
                            line = sz.ReadLine();
                        }
                        sz.Close();
                        break;

                    case "haunted house":
                        StreamReader sh = new StreamReader(@"../../../Story/IntroChoiceLoss.txt");
                        line = sh.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line);
                            line = sh.ReadLine();
                        }
                        sh.Close();
                        break;

                    case "merry-go-round":
                        StreamReader sm = new StreamReader(@"../../../Story/IntroChoiceLoss.txt");
                        line = sm.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line);
                            line = sm.ReadLine();
                        }
                        sm.Close();
                        break;
                    case "ye old mill":
                        StreamReader so = new StreamReader(@"../../../Story/IntroChoiceLoss.txt");
                        line = so.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line);
                            line = so.ReadLine();
                        }
                        so.Close();
                        break;

                    default:
                        ParkMap();
                        break;
                }
            }
        }


    }



        
    }
    


