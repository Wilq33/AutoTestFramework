
namespace AutoTestFramework
{

    public class Program
    {
        static void Main()
        {
            Menu menu = new Menu();

            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");
            menu.Selectors.Click();

        }
    }
}
