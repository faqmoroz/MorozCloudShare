using System;
using System.Collections.Generic;
using System.Text;

namespace MorozCloudShare.Core.Exceptions
{
    /// <summary>
    /// Exceptions that can be viewed by Users.
    /// </summary>
    public class OooopsException:Exception
    {
        public override string Message => "Oooops, something gone wrong!";
    }
}
