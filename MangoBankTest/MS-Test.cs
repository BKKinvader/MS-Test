using Team.Mango.Bank_Application;
using Team.Mango.Bank_Application.TestCode;

namespace MangoBankTest
{
    [TestClass]
    public class AllTest
    {
        //Check if RunBank succesfully created all Users
        [TestMethod]
        public void TestRunBankCreatesFiveUsers()
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
        public void TestAdminLogin()
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
        public void UpdateCurrentcyRate_ShouldReturnRate()
        {

        }
    }
}