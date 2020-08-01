using Microsoft.AspNetCore.Http;
using MorozCloudShare.Core.Common;
using MorozCloudShare.Core.Credentials;
using System;
using System.Collections.Generic;
using System.Text;

namespace MorozCloudShare.Core.Auth
{
    /// <summary>
    /// Interface for authorization service worker.
    /// </summary>
    public interface IAuthorizationService
    {
        /// <summary>
        /// Get token by usercredentials
        /// </summary>
        /// <param name="credentials">User credentials</param>
        /// <param name="httpContext">HttpContext to save token.</param>
        /// <returns>Valid token when success.</returns>
        Result Authorize(User credentials, HttpContext httpContext);
    }
}
