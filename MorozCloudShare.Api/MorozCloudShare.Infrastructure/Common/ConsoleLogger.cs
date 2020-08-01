using MorozCloudShare.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MorozCloudShare.Infrastructure.Common
{
    /// <summary>
    /// Logger that writes to console
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        /// <summary>
        /// Write log.
        /// </summary>
        /// <param name="message">Log message.</param>
        /// <param name="msgType">Message type: errort, info etc...</param>
        public void WriteLog(string message, LogType msgType)
        {
            string consoleMsg = "";
            consoleMsg += DateTime.Now + " ";
            switch (msgType)
            {
                case LogType.None:
                    consoleMsg += "[none]: ";
                    break;
                case LogType.Warning:
                    consoleMsg += "[WARNING]: ";
                    break;
                case LogType.Error:
                    consoleMsg += "[!!!ERROR]: ";
                    break;
                case LogType.Information:
                    consoleMsg += "[information]: ";
                    break;
                case LogType.Other:
                    consoleMsg += "[other]: ";
                    break;
            }
            consoleMsg += message;
            Console.WriteLine(consoleMsg);
        }
    }
}
