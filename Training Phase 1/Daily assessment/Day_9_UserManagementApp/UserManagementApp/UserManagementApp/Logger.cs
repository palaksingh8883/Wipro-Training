using Serilog;

public class Logger
{
    private static readonly ILogger _logger = new LoggerConfiguration()
        .WriteTo.File("app.log", rollingInterval: RollingInterval.Day)
        .CreateLogger();

    // Log an info message
    public static void LogInfo(string message)
    {
        _logger.Information(message);
    }

    // Log an error message
    public static void LogError(string message, Exception ex)
    {
        _logger.Error($"Message: {message}, Exception: {ex.Message}, StackTrace: {ex.StackTrace}");
    }
}
