using Hydrium;
using System.Diagnostics;
namespace ExecuteEngines
{
    public class Engines
    {
        public static void sh()
        {
            string args = Environment.GetEnvironmentVariable("runApp");
            if(Environment.OSVersion.Platform == PlatformID.Unix)
            {
                if(File.Exists("/usr/bin/bash"))
                {
                    Process.Start("/usr/bin/bash", Environment.CurrentDirectory + "/" + args);
                }
                else
                {
                    Engine.OutputSysWE("[SH] No bash detected");
                }
            }
            else
            {
                Engine.OutputSysWE("[SH] Incompatible platform");
            }
        }
    }
}
