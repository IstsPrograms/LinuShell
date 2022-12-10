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
                else if(File.Exists("/bin/bash"))
                {
                    Process.Start("/bin/bash", Environment.CurrentDirectory + "/" + args);
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
        public static void o()
        {
            string args = Environment.GetEnvironmentVariable("runApp");
            if(Environment.OSVersion.Platform == PlatformID.Unix)
            {
                Engine.OutputSysWW("[O] Possible error: Access denied");
                Process.Start($"{Environment.CurrentDirectory}/{args}");
            }
            else
            {
                Engine.OutputSysWE("[O] Incompatible platform");
            }
        }
    }
}
