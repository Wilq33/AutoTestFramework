using NUnit.Framework;
using OpenQA.Selenium;


namespace AutoTestFramework.Scenarios
{
    class LoginInvalidPassword
    {
        IAlert alert;

        public LoginInvalidPassword()
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
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                                  Config.Credentials.Invalid.Password.FourCharacters,
                                  Config.Credentials.Invalid.Password.FourCharacters);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.PasswordLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [Test]

        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                                  Config.Credentials.Invalid.Password.ThirteenCharacters,
                                  Config.Credentials.Invalid.Password.ThirteenCharacters);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.PasswordLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [Test]

        public void Empty()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                                  Config.Credentials.Invalid.Password.Empty,
                                  Config.Credentials.Invalid.Password.Empty);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.PasswordLengthOutOfRange, alert.Text);
            alert.Accept();

        }

        [OneTimeTearDown]

        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}