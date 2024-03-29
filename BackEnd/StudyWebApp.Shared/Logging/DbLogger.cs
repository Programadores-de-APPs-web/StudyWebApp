﻿using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyWebApp.Shared.Logging
{
    public class DbLogger : ILogger
    {
        /// <summary>
        /// Instance of <see cref="DbLoggerProvider" />.
        /// </summary>
        private readonly DbLoggerProvider _dbLoggerProvider;

        /// <summary>
        /// Creates a new instance of <see cref="FileLogger" />.
        /// </summary>
        /// <param name="fileLoggerProvider">Instance of <see cref="FileLoggerProvider" />.</param>
        public DbLogger([NotNull] DbLoggerProvider dbLoggerProvider)
        {
            _dbLoggerProvider = dbLoggerProvider;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        /// <summary>
        /// Whether to log the entry.
        /// </summary>
        /// <param name="logLevel"></param>
        /// <returns></returns>
        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel != LogLevel.None;
        }


        /// <summary>
        /// Used to log the entry.
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="logLevel">An instance of <see cref="LogLevel"/>.</param>
        /// <param name="eventId">The event's ID. An instance of <see cref="EventId"/>.</param>
        /// <param name="state">The event's state.</param>
        /// <param name="exception">The event's exception. An instance of <see cref="Exception" /></param>
        /// <param name="formatter">A delegate that formats </param>
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                // Don't log the entry if it's not enabled.
                return;
            }

            var threadId = Thread.CurrentThread.ManagedThreadId; // Get the current thread ID to use in the log file. 

            // Store record.
            using (var connection = new SqlConnection(_dbLoggerProvider.Options.ConnectionString))
            {
                connection.Open();

                // Add to database.

                // LogLevel
                // ThreadId
                // EventId
                // Exception Message (use formatter)
                // Exception Stack Trace
                // Exception Source

                var registro = new JObject();
                string _LogLevel = logLevel.ToString();

                if (_dbLoggerProvider?.Options?.LogFields?.Any() ?? false)
                {
                    foreach (var logField in _dbLoggerProvider.Options.LogFields)
                    {
                        switch (logField)
                        {
                            case "LogLevel":
                                if (!string.IsNullOrWhiteSpace(logLevel.ToString()))
                                {
                                    registro["LogLevel"] = logLevel.ToString();
                                }
                                break;
                            case "ThreadId":
                                registro["ThreadId"] = threadId;
                                break;
                            case "EventId":
                                registro["EventId"] = eventId.Id;
                                break;
                            case "EventName":
                                if (!string.IsNullOrWhiteSpace(eventId.Name))
                                {
                                    registro["EventName"] = eventId.Name;
                                }
                                break;
                            case "Message":
                                if (!string.IsNullOrWhiteSpace(formatter(state, exception)))
                                {
                                    registro["Message"] = formatter(state, exception);
                                }
                                break;
                            case "ExceptionMessage":
                                if (exception != null &&
                                    !string.IsNullOrWhiteSpace(exception.Message))
                                {
                                    registro["ExceptionMessage"] = exception?.Message;
                                }
                                break;
                            case "ExceptionStackTrace":
                                if (exception != null
                                    && !string.IsNullOrWhiteSpace(exception.StackTrace))
                                {
                                    registro["ExceptionStackTrace"] = exception?.StackTrace;
                                }
                                break;
                            case "ExceptionSource":
                                if (exception != null
                                    && !string.IsNullOrWhiteSpace(exception.Source))
                                {
                                    registro["ExceptionSource"] = exception?.Source;
                                }
                                break;
                        }
                    }
                }


                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = string.Format("INSERT INTO {0} ([Registro], [LogLevel], [FechaCreacion]) " +
                        "VALUES (@Registro, @LogLevel, @FechaCreacion)",
                        _dbLoggerProvider.Options.LogTable);

                    command.Parameters.Add(new SqlParameter("@Registro",
                        JsonConvert.SerializeObject(registro, new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            DefaultValueHandling = DefaultValueHandling.Ignore,
                            Formatting = Formatting.None
                        }).ToString()));
                    command.Parameters.Add(new SqlParameter("@LogLevel", _LogLevel));
                    command.Parameters.Add(new SqlParameter("@FechaCreacion", DateTimeOffset.Now));

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
