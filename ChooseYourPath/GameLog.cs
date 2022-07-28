using System.Diagnostics;



namespace ChooseYourPath
{
    public class GameLog
    {
        public static void GameLogger()
        {

            StreamWriter logFile = File.CreateText("gamelogger.txt");
            Trace.Listeners.Add(new TextWriterTraceListener(logFile));
            Trace.AutoFlush = true;
            Trace.WriteLine("Starting Game Log");
            Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
            using (StreamWriter sw = File.AppendText(@"gamelogger.txt"))
            {
                sw.WriteLine();
            }

        }
    }
}

