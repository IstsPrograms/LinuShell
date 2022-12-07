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
                Process.Start($"/etc/bash.bashrc ", $"{Environment.CurrentDirectory}/{scriptToExecute}");
                Engine.OutputSysNE("[SH] Script executing started!");
            }
            else
            {
                Engine.OutputSysWE("[SH] Incompatible platform");
            }
        }
    }
}
