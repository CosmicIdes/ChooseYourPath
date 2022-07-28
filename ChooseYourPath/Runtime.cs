using System;
using System.Diagnostics;

namespace ChooseYourPath
{
    public static class Runtime
    {
        static Runtime()
        {
            var ThisProcess = Process.GetCurrentProcess(); LastSystemTime = (long)(System.DateTime.Now - ThisProcess.StartTime).TotalMilliseconds; ThisProcess.Dispose();
            StopWatch = new Stopwatch(); StopWatch.Start();
        }
        private static long LastSystemTime;
        private static Stopwatch StopWatch;

        public static long CurrentRuntime { get { return StopWatch.ElapsedMilliseconds + LastSystemTime; } }

    }

}

