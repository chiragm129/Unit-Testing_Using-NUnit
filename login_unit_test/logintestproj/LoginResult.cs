using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logintestproj
{
    public class LoginResult
    {
        public bool IsSuccess { get; set; }
        public bool IsRedirectToDashboard { get; set; }
        public string ErrorMessage { get; set; }
    }

}
