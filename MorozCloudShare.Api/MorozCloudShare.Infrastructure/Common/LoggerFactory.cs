using MorozCloudShare.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MorozCloudShare.Infrastructure.Common
{
    /// <summary>
    /// Loggers fabric implementation.
    /// </summary>
    public class LoggerFactory : ILoggerFactory
    {
        /// <summary>
        /// Factory interface that provides ILogger instances list.
        /// </summary>
        public List<ILogger> Produce()
        {
            List<ILogger> list = new List<ILogger>();
            list.Add(new ConsoleLogger());
            //TODO: add other loggers.
            return list;
        }
    }
}
