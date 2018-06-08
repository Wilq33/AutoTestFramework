using NUnit.Framework;
using OpenQA.Selenium;

namespace AutoTestFramework
{

    public class Program
    {
        IAlert alert;

        static void Main()
        {
            //navigating to Login Form through post
            //Thread.Sleep(1000);

            //Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");

            //NavigateTo.LoginFormThroghThePost();

            //Thread.Sleep(1000);

            //Driver.driver.Quit();
        }

        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void ValidLogin()
        {
            NavigateTo.LoginFormThroughTheMenu();
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.SuccessfulLogin, alert.Text);
            alert.Accept();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
