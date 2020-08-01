using System;
using System.Collections.Generic;
using System.Text;

namespace MorozCloudShare.Core.Common
{
    /// <summary>
    /// Class for returning result from services.
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Status of operation.
        /// </summary>
        public ResultStatus ResultStatus { get; set; }

        /// <summary>
        /// Message for error or rejected states.
        /// </summary>
        public string Messsage { get; set; }
    }

    /// <summary>
    /// Generic Class for returning result with value from services.
    /// </summary>
    /// <typeparam name="T">Returning payload type.</typeparam>
    public class Result<T>:Result
    {
        /// <summary>
        /// Returning payload.
        /// </summary>
        public T Payload { get; set; }
    }
}
