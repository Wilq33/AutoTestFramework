
using System.Threading;

namespace AutoTestFramework
{

    public class Program
    {
        static void Main()
        {
          

            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");

            NavigateTo.LoginFormThroughTheMenu();

            Thread.Sleep(1000);

            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");

            NavigateTo.LoginFormThroghThePost();

            Thread.Sleep(1000);

            Driver.driver.Quit();
        }
    }
}
