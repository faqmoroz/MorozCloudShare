using System;
using System.Collections.Generic;
using System.Text;

namespace MorozCloudShare.Core.Common
{
    /// <summary>
    /// Interface for logging.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Write log.
        /// </summary>
        /// <param name="message">Log message.</param>
        /// <param name="msgType">Message type: errort, info etc...</param>
        void WriteLog(string message, LogType msgType);
    }
}
