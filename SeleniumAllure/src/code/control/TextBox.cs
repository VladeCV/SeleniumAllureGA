using OpenQA.Selenium;

namespace SeleniumAllure.SeleniumAllure.code.control;

public class TextBox : ControlSelenium
{
    public TextBox(By Locator) : base(Locator)
    {

    }

    public void SetText(string value)
    {
        FindControl();
        Control.Clear();
        Control.SendKeys(value);
    }
}