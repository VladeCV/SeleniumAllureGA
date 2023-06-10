using OpenQA.Selenium;

namespace SeleniumAllure.code.factoryBrowser
{
    public interface IBrowser
    {
        IWebDriver Create();
    }
}
