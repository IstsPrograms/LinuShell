using OperManager;
using Cmds;
using Hydrium;
using Services;
using ExecuteEngines;
string cPath = string.Empty;
if(Environment.UserName == "root")
{
    cPath = "/root/";
} 
else
{
    cPath = $"/home/{Environment.UserName}/";
}
Environment.CurrentDirectory = cPath;
Engine.OutputSysNE("[PCONF] Path Configured");
Delegate[] cmds = { CommandsR.cd, CommandsR.dir, CommandsR.cls, CommandsR.ping, CommandsR.shutdown, CommandsR.fget, CommandsR.sys, CommandsR.echo, CommandsR.getd, CommandsR.to, CommandsR.mkzip, CommandsR.unzip, CommandsR.rm, CommandsR.write, CommandsR.mkdir, CommandsR.mkfile, CommandsR.help, CommandsR.ls, CommandsR.clear, CommandsR.about, CommandsR.date, CommandsR.touch};
Action[] services = { };
Delegate[] engines = { Engines.sh };
Operture invokeMgr = new Operture(cmds, services, engines);
await invokeMgr.MainCmd();
Console.ReadKey();