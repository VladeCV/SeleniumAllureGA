using OpenQA.Selenium;
using SeleniumAllure.code.control;

namespace SeleniumAllure.code.page.Todoist
{
    public class MainPage
    {
        public Button loginButton = new Button(By.XPath("//nav//a[text()='Log in']"));
    }
}
