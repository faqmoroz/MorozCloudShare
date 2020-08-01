using System;
using System.Collections.Generic;
using System.Text;

namespace MorozCloudShare.Core.Common
{
    /// <summary>
    /// Interface for service wrapper implementation, that adds logic that wraps service methods.
    /// </summary>
    public interface IServiceWrapper
    {
        /// <summary>
        /// Method for wrapping service actions.
        /// </summary>
        /// <param name="func">Service action.</param>
        /// <returns>Result of service action.</returns>
        Result WrapAction(Func<Result> func);

        /// <summary>
        /// Generic Method for wrapping service actions.
        /// </summary>
        /// <param name="func">Service action.</param>
        /// <returns>Result of service action.</returns>
        Result<T> WrapAction<T>(Func<Result<T>> func);
    }
}
