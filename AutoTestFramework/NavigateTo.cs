using AutoTestFramework.UIElements;
using System.Threading;

namespace AutoTestFramework
{
    public static class NavigateTo
    {
        public static void LoginFormThroughTheMenu()
        {
            Menu menu = new Menu();
            TestScenariosPage tsPage = new TestScenariosPage();

            menu.TestScenarios.Click();
            Thread.Sleep(1000);
            tsPage.LoginForm.Click();
        }

        public static void LoginFormThroghThePost()
        {
            Menu menu = new Menu();
            TestCasesPage tcPage = new TestCasesPage();
            UsernameFieldPost ufPost = new UsernameFieldPost();

            menu.TestCases.Click();
            Thread.Sleep(1000);
            tcPage.UsernameFieldPost.Click();
            Thread.Sleep(1000);
            ufPost.LoginFormLink.Click();
        } 
    }
}
