using Microsoft.AspNetCore.Http;
using MorozCloudShare.Core.Auth;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MorozCloudShare.Infrastructure.Auth
{
    /// <summary>
    /// Middleware to control auth token
    /// </summary>
    public class AuthControlMiddleware:IMiddleware
    {
        /// <summary>
        /// Token validation instance.
        /// </summary>
        private IAuthControl _authControl;

        /// <summary>
        /// Ctor.
        /// <paramref name="authControl">AuthControl instance</paramref>
        /// </summary>       
        public AuthControlMiddleware(IAuthControl authControl)
        {
            _authControl = authControl;
        }        

        /// <summary>
        /// Invoke async.
        /// </summary>
        /// <param name="context">HttpContext.</param>
        /// <param name="next">Next middleware</param>
        /// <returns></returns>
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (_authControl.IsTokenValid(context))
            {
                await next(context);
            }
            else
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.Response.WriteAsync("Token is invalid");
            }
        }
    }
}
