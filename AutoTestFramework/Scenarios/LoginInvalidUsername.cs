using NUnit.Framework;
using OpenQA.Selenium;


namespace AutoTestFramework.Scenarios
{
    class LoginInvalidUsername
    {
        IAlert alert;

        public LoginInvalidUsername()
        {

        }

        [OneTimeSetUp]

        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormThroughTheMenu();  
        }

        [Test]
        public void LessThan5Characters()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.FourCharacters,
                                  Config.Credentials.Valid.Password,
                                  Config.Credentials.Valid.Password);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [Test]

        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.ThirteenCharacters,
                                  Config.Credentials.Valid.Password,
                                  Config.Credentials.Valid.Password);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]

        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
