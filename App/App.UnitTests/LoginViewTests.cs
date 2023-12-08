using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MySqlConnector;
using Presentation.Views;

namespace App.UnitTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AuthenticationTests
    {
        [TestMethod]
        public void AuthenticateUser_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            var authentication = new LoginView(); // Replace with the actual class name

            // Act
            bool result = authentication.AuthenticateUser("validUsername", "validPassword");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AuthenticateUser_InvalidCredentials_ReturnsFalse()
        {
            // Arrange
            var authentication = new LoginView(); // Replace with the actual class name

            // Act
            bool result = authentication.AuthenticateUser("invalidUsername", "invalidPassword");

            // Assert
            Assert.IsFalse(result);
        }

        //[TestMethod]
        //public void btnLogin_Click_ValidCredentials_ShowsMessageBoxAndOpensMainView()
        //{
        //    // Arrange
        //    var form = new LoginView(); // Replace with the actual form class name

        //    // Act
        //    form.txtUser.Text = "validUsername";
        //    form.txtPass.Password = "validPassword";
        //    form.btnLogin_Click(null, null);

        //    // Assert
        //    // You may need to add more assertions based on your specific implementation
        //    Assert.AreEqual("Login successful!", form.lastMessageBoxText);
        //    Assert.IsTrue(form.mainViewShown);
        //}

        //[TestMethod]
        //public void btnLogin_Click_InvalidCredentials_ShowsInvalidCredentialsMessageBox()
        //{
        //    // Arrange
        //    var form = new LoginView(authentication); // Replace with the actual form class name

        //    // Act
        //    form.txtUser.Text = "invalidUsername";
        //    form.txtPass.Password = "invalidPassword";
        //    form.btnLogin_Click(null, null);

        //    // Assert
        //    // You may need to add more assertions based on your specific implementation
        //    Assert.AreEqual("Invalid username or password. Please try again.", form.lastMessageBoxText);
        //    Assert.IsFalse(form.mainViewShown);
        //}
    }
}
