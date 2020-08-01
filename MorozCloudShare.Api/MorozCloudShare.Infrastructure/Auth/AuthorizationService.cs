using Microsoft.AspNetCore.Http;
using MorozCloudShare.Core.Auth;
using MorozCloudShare.Core.Common;
using MorozCloudShare.Core.Credentials;
using System;
using System.Collections.Generic;
using System.Text;

namespace MorozCloudShare.Infrastructure.Auth
{
    /// <summary>
    /// Authorization service implementation.
    /// </summary>
    public class AuthorizationService : IAuthorizationService
    {
        /// <summary>
        /// Get token by usercredentials
        /// </summary>
        /// <param name="credentials">User credentials</param>
        /// <param name="httpContext">HttpContext to save token.</param>
        /// <returns>Valid token when success.</returns>
        public Result Authorize(User credentials, HttpContext httpContext)   
        {
            //TODO: logic.
            throw new NotImplementedException();
        }
    }
}
