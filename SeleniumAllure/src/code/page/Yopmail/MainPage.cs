using OpenQA.Selenium;
using SeleniumAllure.SeleniumAllure.code.control;

namespace SeleniumAllure.SeleniumAllure.code.page.Yopmail
{
    public class MainPage
    {
        public TextBox emailInput = new TextBox(By.XPath("//input[@id='login']"));
        public Button checkInboxBtn = new Button(By.XPath("//div[@id='refreshbut']/button"));
    }
}
