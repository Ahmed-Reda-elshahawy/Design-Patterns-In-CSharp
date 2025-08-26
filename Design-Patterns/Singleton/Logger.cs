namespace Design_Patterns.Singleton
{
    public enum LogLevel
    {
        Info,
        Warning,
        Error
    }

    public sealed class Logger
    {
        private static readonly Lazy<Logger> _lazyInstance =
            new Lazy<Logger>(() => new Logger());

        public static Logger Instance => _lazyInstance.Value;

        // Current log level (default: Info)
        public LogLevel CurrentLogLevel { get; set; } = LogLevel.Info;

        // Private constructor so no one can create new instances
        private Logger() { }

        public void Log(string message, LogLevel level = LogLevel.Info)
        {
            if (level >= CurrentLogLevel) // only log if it meets the threshold
            {
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] [{level}] {message}");
            }
        }
    }
}
