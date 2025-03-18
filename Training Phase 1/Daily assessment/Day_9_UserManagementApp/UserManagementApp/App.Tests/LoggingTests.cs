using System;
using NUnit.Framework;
using Serilog;

public class LoggingService
{
    public void LogError(Exception ex)
    {
        Log.Error(ex, "An error occurred");
    }

    public void LogInformation(string message)
    {
        Log.Information(message);
    }
}
