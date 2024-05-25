using Newtonsoft.Json;
using System.Diagnostics;

namespace megaDesk
{
    internal static class Program
    {
        public static string jsonFilePath = @"quotes.json";
        public static List<DeskQuote> quotes { get; set; } = DeskQuote.loadQuotesFromJSON(jsonFilePath);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());
        }
    }
}