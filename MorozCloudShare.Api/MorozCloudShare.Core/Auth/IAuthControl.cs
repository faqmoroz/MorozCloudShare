using Microsoft.AspNetCore.Http;
using MorozCloudShare.Core.Credentials;
using System;
using System.Collections.Generic;
using System.Text;

namespace MorozCloudShare.Core.Auth
{
    /// <summary>
    /// Interface describes controlling authorization.
    /// </summary>
    public interface IAuthControl
    {
        /// <summary>
        /// Method to validate passed token saved in httpContext. 
        /// </summary>
        /// <param name="token">HttpContext.</param>
        /// <returns>Is stored token valid.</returns>
        bool IsTokenValid(HttpContext httpContext);
    }
}
