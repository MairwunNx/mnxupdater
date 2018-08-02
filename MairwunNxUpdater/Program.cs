using System;
using System.Diagnostics;
using System.IO;

namespace MairwunNxUpdater
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                string process = args[1].Replace(".exe", "");

                while (Process.GetProcessesByName(process).Length > 0)
                {
                    Process[] myProcesses2 = Process.GetProcessesByName(process);

                    for (int i = 1; i < myProcesses2.Length; i++) { myProcesses2[i].Kill(); }
                }

                if (File.Exists(args[1])) { File.Delete(args[1]); }

                File.Move(args[0], args[1]);

                Process.Start(args[1]); Process.GetCurrentProcess().Kill();
            }
            catch (Exception exception)
            {
                Console.WriteLine("<!== Update finished with errors, sorry please :(( ==!>\n");

                Console.WriteLine(exception.ToString());

                Console.ReadKey();
            }
        }
    }
}
