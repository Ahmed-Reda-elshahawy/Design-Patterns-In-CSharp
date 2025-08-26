using Design_Patterns.Singleton;

namespace Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logger = Logger.Instance;

            // Set the minimum log level
            logger.CurrentLogLevel = LogLevel.Warning;

            logger.Log("This is an info message", LogLevel.Info);     // Not shown
            logger.Log("This is a warning", LogLevel.Warning);       // Shown
            logger.Log("This is an error!", LogLevel.Error);         // Shown
        }
    }
}
