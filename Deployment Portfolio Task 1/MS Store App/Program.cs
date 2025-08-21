using MS_Store_App_Security;

namespace MS_Store_App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int securityAlgorithm = 1 + 1;
            if (securityAlgorithm != Security.Code) return;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new WindowName());
        }
    }
}