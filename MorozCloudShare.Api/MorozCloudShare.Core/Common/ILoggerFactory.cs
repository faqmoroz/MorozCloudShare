using System;
using System.Collections.Generic;
using System.Text;

namespace MorozCloudShare.Core.Common
{
    /// <summary>
    /// Factory interface that provides ILogger instances list.
    /// </summary>
    public interface ILoggerFactory
    {
        /// <summary>
        /// Produce ILogger List.
        /// </summary>
        /// <returns>ILogger Instances</returns>
        List<ILogger> Produce();
    }
}
