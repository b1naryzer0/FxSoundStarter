using System.Diagnostics;

namespace FxSoundRestarter
{
    class Program
    {
        static void Main(string[] args)
        {
            string processName = "fxsound";
            string exePath = @"C:\Program Files\FxSound LLC\FxSound\FxSound.exe";
            string arguments = @"--output=""OUT 1-2 (BEHRINGER UMC 404HD 192k)"" --run_minimized"; // change this to your own soundcard

            KillProcess(processName);
            KillProcess(processName);
            Thread.Sleep(3000);
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = exePath,
                    Arguments = arguments,
                    UseShellExecute = true
                };
                Process.Start(startInfo);
            }
            catch
            {
                // catch
            }

            // finish
        }

        static void KillProcess(string name)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName(name);
                foreach (var process in processes)
                {
                    process.Kill();
                    process.WaitForExit(2000); // wait 2 sec
                }
            }
            catch
            {
                // ignore errors
            }
        }
    }
}
