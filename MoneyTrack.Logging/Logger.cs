using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using System;

namespace MoneyTrack.Logging
{
    public static class Logger
    {
        /// <summary>
        /// Configures the logger
        /// </summary>
        /// <param name="seqUrl">The base URL of the Seq server that log events will be written to.</param>
        /// <param name="logEventlevel">Specifies the meaning and relative importance of a log event</param>
        public static void Init(string seqUrl, LogEventLevel logEventlevel = LogEventLevel.Information)
        {
            var loggingLevelSwitch = new LoggingLevelSwitch(logEventlevel);

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.ControlledBy(loggingLevelSwitch)
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .MinimumLevel.Override("System", LogEventLevel.Warning)
                .WriteTo.Seq(seqUrl)
                .Enrich.WithProperty("Application", "MoneyTrackApi")
                .CreateLogger();
        }
        public static void Init(IConfigurationRoot config)
        {
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                .CreateLogger();
        }
        /// <summary>
        /// Logs a verbose event
        /// </summary>
        /// <param name="messageTemplate">The template message</param>
        /// <param name="propertyValues">The logging parameters</param>
        public static void LogVerbose(string messageTemplate, params object[] propertyValues)
        {
            Log.Verbose(messageTemplate, propertyValues);
        }

        /// <summary>
        /// Logs a debug event
        /// </summary>
        /// <param name="messageTemplate">The template message</param>
        /// <param name="propertyValues">The logging parameters</param>
        public static void LogDebug(string messageTemplate, params object[] propertyValues)
        {
            Log.Debug(messageTemplate, propertyValues);
        }

        /// <summary>
        /// Logs an informational event
        /// </summary>
        /// <param name="messageTemplate">The template message</param>
        /// <param name="propertyValues">The logging parameters</param>
        public static void LogInformation(string messageTemplate, params object[] propertyValues)
        {
            Log.Information(messageTemplate, propertyValues);
        }

        /// <summary>
        /// Logs a warning event
        /// </summary>
        /// <param name="messageTemplate">The template message</param>
        /// <param name="propertyValues">The logging parameters</param>
        public static void LogWarning(string messageTemplate, params object[] propertyValues)
        {
            Log.Warning(messageTemplate, propertyValues);
        }

        /// <summary>
        /// Logs an error event
        /// </summary>
        /// <param name="exception">The exception to be logged</param>
        /// <param name="messageTemplate">The template message</param>
        /// <param name="propertyValues">The logging parameters</param>
        public static void LogError(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Log.Error(exception, messageTemplate, propertyValues);
        }

        /// <summary>
        /// Logs a fatal event
        /// </summary>
        /// <param name="exception">The exception to be logged</param>
        /// <param name="messageTemplate">The template message</param>
        /// <param name="propertyValues">The logging parameters</param>
        public static void LogFatal(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Log.Fatal(exception, messageTemplate, propertyValues);
        }
    }

}
