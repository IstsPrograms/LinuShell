using Hydrium;
using System.Diagnostics;
namespace ExecuteEngines
{
    public class Engines
    {
        public static void sh()
        {
            string scriptToExecute = Environment.GetEnvironmentVariable("runApp");
            if(Environment.OSVersion.Platform == PlatformID.Unix)
            {
                Process.Start($"bash {Environment.CurrentDirectory}/{scriptToExecute}");
                Engine.OutputSysNE("[SH] Script executing started!");
            }
            else
            {
                Engine.OutputSysWE("[SH] Incompatible platform");
            }
        }
    }
}
