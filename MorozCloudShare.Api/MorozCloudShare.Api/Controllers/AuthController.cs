using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MorozCloudShare.Core.Auth;
using MorozCloudShare.Core.Common;
using MorozCloudShare.Core.Credentials;

namespace MorozCloudShare.Api.Controllers
{
    /// <summary>
    /// User authorization.
    /// </summary>
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        /// <summary>
        /// Auth. service instance.
        /// </summary>
        private IAuthorizationService _authorizationService;

        /// <summary>
        /// Service wrapper instance.
        /// </summary>
        private IServiceWrapper _serviceWrapper;

        /// <summary>
        /// Ctor with DI.
        /// </summary>
        public AuthController(
            IAuthorizationService authorizationService,
            IServiceWrapper serviceWrapper)
        {
            _authorizationService = authorizationService;
            _serviceWrapper = serviceWrapper;
        }

        // POST api/v1/Auth
        /// <summary>
        /// Pass user credentials to authorize.
        /// </summary>
        /// <param name="value">User credentials.</param>
        [HttpPost]
        public void Post([FromBody] User value)
        {
            Result res = _serviceWrapper.WrapAction(
                () => _authorizationService.Authorize(value, HttpContext));
            //TODO return something?
        }

     
    }
}
