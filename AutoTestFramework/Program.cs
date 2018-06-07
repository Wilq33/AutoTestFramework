
using System.Threading;

namespace AutoTestFramework
{

    public class Program
    {
        static void Main()
        {
          

            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");

            NavigateTo.LoginFormThroughTheMenu();
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);



            //navigating to Login Form through post
            //Thread.Sleep(1000);

            //Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");

            //NavigateTo.LoginFormThroghThePost();

            //Thread.Sleep(1000);

            //Driver.driver.Quit();
        }
    }
}
