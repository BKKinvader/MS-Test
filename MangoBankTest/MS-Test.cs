using Microsoft.VisualStudio.TestPlatform.TestHost;
using Team.Mango.Bank_Application;
using Team.Mango.Bank_Application.TestCode;

namespace MangoBankTest
{
    [TestClass]
    public class AllTest
    {
        //Check if RunBank succesfully created all Users
        [TestMethod]
        public void CreateUser_RunBankShouldReturn_5_Users()
        {
            // Arrange
            MethodToTest methodToTest = new MethodToTest();

            // Act
            List<User> users = methodToTest.RunBank();

            // Assert
            Assert.AreEqual(5, users.Count);
        }



        //Check if User is Admin 
        [TestMethod]
        public void LoginAdmin_ShouldReturnTrue()
        {
            //Arrange
            var methodToTest = new MethodToTest();
            var users = methodToTest.RunBank(); //Create all Users
            string username = "admin";
            string password = "admin";

            //Act
            var result = methodToTest.UserLogin(users, username, password); //Send all users to UserLogin

            //Arrange
            Assert.IsTrue(result, "Admin is Online");
        }

        [TestMethod]
        public void OpenSavingsAccount_ShouldReturn_CorrectAccountNameAndAmount()
        {
            // Arrange
            string expectedAccountName = "Test Account";
            double expectedAmount = 999;
            string expectedCurrency = "SEK";

            // Act
            var bankAccount = new BankAccount(expectedAccountName, expectedAmount, expectedCurrency);

            // Assert
            Assert.AreEqual(expectedAccountName, bankAccount.AccountName);
            Assert.AreEqual(expectedAmount, bankAccount.Balance);
            
        }
    }
}