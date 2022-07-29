namespace ChooseYourPath
{
    public class OldMill
    {
        private static string? line;

        public static void OldMillRide()
        {
            StreamReader so = new StreamReader(@"../../../Story/OldMillIntro.txt");
            line = so.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = so.ReadLine();
            }
            so.Close();

            string? MillChoice = Console.ReadLine();
            if (MillChoice == "yes")
            {
                StreamReader shy = new StreamReader(@"../../../Story/OldMillSaloon.txt");
                line = shy.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = shy.ReadLine();
                }
                shy.Close();

                string? SaloonChoice = Console.ReadLine();
                if (SaloonChoice == "get out")
                {
                    StreamReader ssy = new StreamReader(@"../../../Story/OldMillSaloon2.txt");
                    line = ssy.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = ssy.ReadLine();
                    }
                    ssy.Close();
                    GameEnd.GameEndOptions();
                }
                else if (SaloonChoice == "continue")

                {
                    StreamReader ssy = new StreamReader(@"../../../Story/OldMillJail.txt");
                    line = ssy.ReadLine();
                    while (line != null)
                        {
                            Console.WriteLine(line);
                            line = ssy.ReadLine();
                        }
                    ssy.Close();

                    string? JailChoice = Console.ReadLine();
                    if (JailChoice == "get out")
                    {
                        StreamReader ssj = new StreamReader(@"../../../Story/OldMillJail2.txt");
                        line = ssj.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line);
                            line = ssj.ReadLine();
                        }
                        ssj.Close();
                        GameEnd.GameEndOptions();
                    }
              
                    else if (JailChoice == "continue")
                    {
                        StreamReader sscb = new StreamReader(@"../../../Story/OldMillGraveyard.txt");
                        line = sscb.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line);
                            line = sscb.ReadLine();
                        }
                        sscb.Close();
                       
                            string? GraveyardChoice1 = Console.ReadLine();
                            if (GraveyardChoice1 == "get out" && Game.Inventory.Contains("Gift from the Deer God") == true)
                            {
                                StreamReader ssd = new StreamReader(@"../../../Story/OldMillDeerGodHelp.txt");
                                line = ssd.ReadLine();
                                while (line != null)
                                {
                                    Console.WriteLine(line);
                                    line = ssd.ReadLine();
                                }
                                ssd.Close();
                                Console.WriteLine("WELCOME, " + Program.UserName + ". DO YOU WISH TO RETURN HOME?");
                                Console.WriteLine("\r\n\r\nThe Deer God kneels before you, its many jointed legs folding down unnaturally until it reaches a level where you could easily climb upon its back.");
                                Console.WriteLine("\r\nYou have no choice but to climb on. You do not expect it to actually take you home, but perhaps it will take you somewhere better than here. \r\n\r\nEND");
                                GameEnd.GameEndOptions();
                            }
                            else if (GraveyardChoice1 == "get out" && Game.Inventory.Contains("Gift from the Deer God") == false)
                            {
                                StreamReader ssdn = new StreamReader(@"../../../Story/OldMillDeerGodNo.txt");
                                line = ssdn.ReadLine();
                                while (line != null)
                                {
                                    Console.WriteLine(line);
                                    line = ssdn.ReadLine();
                                }
                                ssdn.Close();
                                GameEnd.GameEndOptions();
                            }
                            else if (GraveyardChoice1 == "continue")
                            {
                                StreamReader ssdn = new StreamReader(@"../../../Story/OldMillFinal.txt");
                                line = ssdn.ReadLine();
                                while (line != null)
                                {
                                    Console.WriteLine(line);
                                    line = ssdn.ReadLine();
                                }
                                ssdn.Close();
                                GameEnd.GameEndOptions();
                            }
                        }
                    }
                    else if (MillChoice == "no")
                    {
                        Console.WriteLine("You must return here eventually, but perhaps now isn’t the time.");
                        Game.ParkMap();
                    }
                }
            }
        }
    }

