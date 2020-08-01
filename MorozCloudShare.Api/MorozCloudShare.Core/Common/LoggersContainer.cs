using System;
using System.Collections.Generic;
using System.Text;

namespace MorozCloudShare.Core.Common
{
    /// <summary>
    /// Class that contains loggers chain.
    /// </summary>
    public class LoggersContainer:ILogger
    {
        /// <summary>
        /// Loggers chain.
        /// </summary>
        private List<ILogger> _loggers;

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="ILoggerFactory">Factory for ILogger implementations.</param>
        public LoggersContainer(ILoggerFactory factory)
        {
            _loggers = factory.Produce();
        }

        /// <summary>
        /// Write log.
        /// </summary>
        /// <param name="message">Log message.</param>
        /// <param name="msgType">Message type: errort, info etc...</param>
        public void WriteLog(string message, LogType msgType)
        {
            _loggers.ForEach(o => o.WriteLog(message, msgType));
        }
    }
}
