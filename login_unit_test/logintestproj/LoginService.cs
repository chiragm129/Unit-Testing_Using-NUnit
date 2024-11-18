using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logintestproj
{
    public class LoginService
    {
        // This dictionary simulates a simple user database for demonstration purposes.
        private readonly Dictionary<string, string> _userDatabase = new Dictionary<string, string>
    {
        { "valid@example.com", "correctpassword" }  // A valid user entry for testing
    };

        public LoginResult Login(LoginViewModel loginViewModel)
        {
            var result = new LoginResult();

            // Check if the email and password match a valid entry in the "database"
            if (_userDatabase.TryGetValue(loginViewModel.Email, out var correctPassword)
                && correctPassword == loginViewModel.Password)
            {
                result.IsSuccess = true;
                result.IsRedirectToDashboard = true;
            }
            else
            {
                result.IsSuccess = false;
                result.ErrorMessage = "Email or password not found. Please try again.";
                result.IsRedirectToDashboard = false;
            }

            return result;
        }
    }

}
