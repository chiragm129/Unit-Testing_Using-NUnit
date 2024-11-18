//using Microsoft.VisualStudio.TestTools.UnitTesting;
using logintestproj;
using NUnit.Framework;
using System;

namespace loginTest
{
    [TestFixture]
    public class LoginTests
    {
        private LoginService _loginService;
        private LoginViewModel _loginViewModel;

        [SetUp]
        public void SetUp()
        {
            // Initialize the LoginService and LoginViewModel before each test.
            _loginService = new LoginService();
            _loginViewModel = new LoginViewModel();
        }

        [Test]

        public void InvalidLogin_ShowsErrorMessage()
        {
            // Arrange
            _loginViewModel.Email = "invalid@example.com";
            _loginViewModel.Password = "wrongpassword";

            // Act
            var result = _loginService.Login(_loginViewModel);

            // Assert
            Assert.That(result.IsSuccess, Is.False, "Login should fail with invalid credentials.");
            Assert.That(result.ErrorMessage, Is.EqualTo("Email or password not found. Please try again."));
            Assert.That(result.IsRedirectToDashboard, Is.False, "User should not be redirected to the dashboard.");


        }

        [Test]
        public void ValidLogin_RedirectsToDashboard()
        {
            // Arrange
            _loginViewModel.Email = "valid@example.com";
            _loginViewModel.Password = "correctpassword";

            // Act
            var result = _loginService.Login(_loginViewModel);

            // Assert
            Assert.That(result.IsSuccess, Is.True, "Login should succeed with valid credentials.");
            Assert.That(result.IsRedirectToDashboard, Is.True, "User should be redirected to the dashboard.");
            Assert.That(result.ErrorMessage, Is.Null, "No error message should be displayed.");


        }

        [Test]
        public void PasswordMask_TogglesVisibility()
        {
            // Arrange
            _loginViewModel.IsPasswordMasked = true;

            // Act
            _loginViewModel.TogglePasswordMask();  // Simulates clicking the eye icon

            // Assert
            Assert.That(_loginViewModel.IsPasswordMasked, Is.False, "Password should be unmasked after clicking the eye icon.");
            Assert.That(_loginViewModel.PasswordMaskIcon, Is.EqualTo("eye-crossed-icon"), "Icon should be eye-crossed after unmasking.");

            // Act again to toggle back to masked
            _loginViewModel.TogglePasswordMask();

            // Assert again
            Assert.That(_loginViewModel.IsPasswordMasked, Is.True, "Password should be masked again after clicking the eye icon.");
            Assert.That(_loginViewModel.PasswordMaskIcon, Is.EqualTo("eye-icon"), "Icon should be eye after masking.");

        }
    }
}
