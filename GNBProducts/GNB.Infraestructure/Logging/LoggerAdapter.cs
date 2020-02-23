using GNB.AppCore.Interfaces;
using Microsoft.Extensions.Logging;
using System;

namespace GNB.Infraestructure.Logging
{
    public class LoggerAdapter<T> : IAppLogger<T>
    {
        private readonly ILogger<T> _Logger;

        public LoggerAdapter(ILoggerFactory loggerFactory) 
        {
            _Logger = loggerFactory.CreateLogger<T>();
        }

        public void LogInformation(string message, params object[] args)
        {
            _Logger.LogWarning(message, args);
        }

        public void LogWarning(string message, params object[] args)
        {
            _Logger.LogInformation(message, args);
        }
    }
}
