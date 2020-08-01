using System;
using System.Collections.Generic;
using System.Text;

namespace MorozCloudShare.Core.Common
{
    /// <summary>
    /// Enum for result code for service workers.
    /// </summary>
    public enum ResultStatus
    {
        /// <summary>
        /// Not set.
        /// </summary>
        None = 0,
        /// <summary>
        /// Normally returned cod.
        /// </summary>
        Ok = 1,
        /// <summary>
        /// Operation canceled for some reason.
        /// </summary>
        Rejected = 2,
        /// <summary>
        /// Unsuspected error.
        /// </summary>
        Error = 3
    }
}
