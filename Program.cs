using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace MCJEPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            var ver = "0.0.0.2";
            Console.Title = $"MCJEPL Ver:{ver} Made With ♥ By Games_Crack (Beta)";
            Console.WriteLine($"MineCraftJavaEditonPortableLauncher C# EDITON Ver:{ver} Finaly Running!");
            Console.WriteLine("Report buggs to \"https://github.com/Games-Crack/MCJEPE\"");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //i know this part is crap but i am to lazy
            Console.WriteLine($@"

         License For MCJEPE(This Programm Or software)

                       MIT License

   {"\""}Minecraft{"\""} Is a trademark of Mojang Synergies AB

 ____    ____   ______     _____  ________  _______  _____    
|_   \  /   _|.' ___  |   |_   _||_   __  ||_   __ \|_   _|
  |   \/   | / .'   \_|     | |    | |_ \_|  | |__) | | |
  | |\  /| | | |        _   | |    |  _| _   |  ___/  | |
 _| |_\/_| |_\ `.___.'\| |__' |   _| |__/ | _| |_    _| |__/ |
|_____||_____|`.____ .'`.____.'  |________||_____|  |________|
");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("THIS IS BETA SOFTWARE WITHOUT ANY WARRENTY");
            var cdir = Directory.GetCurrentDirectory();
            var gamedir = cdir + "\\AppData\\Roaming";
            if (!Directory.Exists($"{gamedir}"))
            {
                //creating Directory structure
                Directory.CreateDirectory($@"{cdir}\AppData");
                Directory.CreateDirectory($@"{cdir}\AppData\Roaming");
                Directory.CreateDirectory($@"{cdir}\AppData\LocalLow");
                Directory.CreateDirectory($@"{cdir}\AppData\Local");
                Directory.CreateDirectory($@"{cdir}\bin");
            }
            if ((File.Exists($@"{cdir}\bin\Minecraft.exe")))
            {
                Environment.SetEnvironmentVariable("AppData", $"{gamedir}");
                Environment.SetEnvironmentVariable("LocalAppdata", $"{gamedir + "\\AppData\\LocalLow\\"}");
                Environment.SetEnvironmentVariable("UserProfile", $"{cdir}");
                Console.WriteLine("Starting Minecraft");
                Process.Start($@"{cdir}\bin\Minecraft.exe");
                Console.WriteLine("All done!");
                System.Threading.Thread.Sleep(5000);
                Console.ForegroundColor = ConsoleColor.Gray;
                System.Environment.Exit(0);
            }
            if ((!File.Exists($@"{cdir}\bin\Minecraft.exe")))
            {
                bool confirmed = false;

                while (!confirmed)
                {
                    Console.WriteLine("type 'yes' if you Accept the Minecraft EULA and the Privacy Policy");
                    Console.WriteLine(@"EULA:""https://minecraft.net/terms"" Terms:""https://go.microsoft.com/fwlink/?LinkId=521839""");
                    Console.WriteLine(@"if you type 'yes' Minecraft.exe will be downloaded and an setup process begins");
                    string option = Console.ReadLine();
                    if (option == "yes")
                    {
                        confirmed = true;
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = "cmd.exe";
                        startInfo.Arguments = $@"/C curl https://launcher.mojang.com/download/Minecraft.exe -o {cdir}\bin\minecraft.exe";
                        process.StartInfo = startInfo;
                        process.Start();
                        Thread.Sleep(5000);
                        Environment.SetEnvironmentVariable("AppData", $"{gamedir}");
                        Environment.SetEnvironmentVariable("LocalAppdata", $"{gamedir + "\\AppData\\LocalLow\\"}");
                        Environment.SetEnvironmentVariable("UserProfile", $"{cdir}");
                        Console.WriteLine("Starting Minecraft");
                        Process.Start($@"{cdir}\bin\Minecraft.exe");
                        Console.WriteLine("All done!");
                        System.Threading.Thread.Sleep(5000);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        System.Environment.Exit(0);
                    }

                }
            }
        }
    }
}
