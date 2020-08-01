using Microsoft.AspNetCore.Http;
using MorozCloudShare.Core.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace MorozCloudShare.Infrastructure.Auth
{
    /// <summary>
    /// Controlling validity of token.
    /// </summary>
    public class AuthControl : IAuthControl
    {
        /// <summary>
        /// Method to validate passed token saved in httpContext. 
        /// </summary>
        /// <param name="token">HttpContext.</param>
        /// <returns>Is stored token valid.</returns>
        public bool IsTokenValid(HttpContext httpContext)
        {
            return true;
            // TODO: logic to look if token valid
            throw new NotImplementedException();
        }
    }
}
