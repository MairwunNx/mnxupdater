using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace mnxupdater
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread.Sleep(300);

            try
            {
                if (File.Exists(args[0]))
                {
                    File.Delete(args[0]);
                }

                File.Move(args[1], args[0]);

                Process.Start(args[0]);
                Process.GetCurrentProcess().Kill();
            }
            catch (Exception exception)
            {
                File.WriteAllText("updater-crash-report.log", exception.ToString());
            }
        }
    }
}
