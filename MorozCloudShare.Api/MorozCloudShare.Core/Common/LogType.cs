using System;
using System.Collections.Generic;
using System.Text;

namespace MorozCloudShare.Core.Common
{
    /// <summary>
    /// Type of log message.
    /// </summary>
    public enum LogType
    {
        /// <summary>
        ///Not set. 
        /// </summary>
        None = 0,
        /// <summary>
        /// Warning information.
        /// </summary>
        Warning = 10,
        /// <summary>
        /// Error information.
        /// </summary>
        Error = 20,
        /// <summary>
        /// Info msgs.
        /// </summary>
        Information = 30,
        /// <summary>
        /// Other types.
        /// </summary>
        Other = 40
    }
}
