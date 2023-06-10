using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAllure.code.factoryBrowser;

namespace SeleniumAllure.SeleniumAllure.code.factoryBrowser
{
    public class Chrome : IBrowser
    {
        public IWebDriver Create()
        { 
            var options = new ChromeOptions();
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--headless");
            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
