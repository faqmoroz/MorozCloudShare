using System;
using System.Collections.Generic;
using System.Text;

namespace MorozCloudShare.Core.Credentials
{
    /// <summary>
    /// User login and password for auth.
    /// NOTE: pass password over https or other secured connection.
    /// </summary>
    public class User
    {
        /// <summary>
        /// User login.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// User pass.
        /// </summary>
        public string Password { get; set; }
    }
}
