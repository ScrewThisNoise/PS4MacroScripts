using System;
using System.IO;

namespace PS4MacroScripts
{
    public static class Logger
    {
        public static StreamWriter MacroLogger { get; set; }
        public static string LastSceneName { get; set; }

        public static void Initiate(string Script)
        {
            try
            {
                MacroLogger = new StreamWriter($"{Script}.log") {AutoFlush = true};
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void Writer(string LogMessage)
        {
            string time = DateTime.Now.ToString("h:mm:ss tt");
            try
            {
                MacroLogger.WriteLine($"{time} : {LogMessage}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void Destroy()
        {
            try
            {
                MacroLogger.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void LastScene(string input)
        {
            LastSceneName = input;
        }
    }
}