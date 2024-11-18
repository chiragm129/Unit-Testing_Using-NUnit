using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logintestproj
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsPasswordMasked { get; set; } = true;
        public string PasswordMaskIcon => IsPasswordMasked ? "eye-icon" : "eye-crossed-icon";

        // Toggle the password mask on and off
        public void TogglePasswordMask()
        {
            IsPasswordMasked = !IsPasswordMasked;
        }
    }

}
