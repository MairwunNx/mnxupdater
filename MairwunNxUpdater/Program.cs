using System;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace MairwunNxUpdater
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("<!== MairwunNx Updater Tool : 1.0R Rv1 B1 (060618) ==!>\n");

            try
            {
                string process = args[1].Replace(".exe", "");

                Console.WriteLine("<!== Starting update! Close updatable applications ==!>\n");

                while (Process.GetProcessesByName(process).Length > 0)
                {
                    Process[] myProcesses2 = Process.GetProcessesByName(process);

                    for (int i = 1; i < myProcesses2.Length; i++) { myProcesses2[i].Kill(); }
                }

                if (File.Exists(args[1])) { File.Delete(args[1]); }

                File.Move(args[0], args[1]);

                Console.WriteLine("<!== Update done! Your application will now start! ==!>\n");

                Thread.Sleep(200);

                Process.Start(args[1]); Process.GetCurrentProcess().Kill();
            }
            catch (Exception exception)
            {
                Console.WriteLine("<!== Update finished with errors, sorry please :(( ==!>\n");

                Console.WriteLine(exception.ToString());
            }
        }
    }
}
