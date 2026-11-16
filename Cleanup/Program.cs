using Settings.Services;

namespace Cleanup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UninstallService.Cleanup();
            }
            catch (Exception ex)
            {
                string logPath = Path.Combine(
                    Path.GetTempPath(),
                    "DevDashboard-Uninstall.log"
                );

                File.AppendAllText(logPath, ex + Environment.NewLine);

                Console.WriteLine("error on Cleanup check fil for more info " + logPath);
                Console.ReadKey();

            }
        }
    }
}
