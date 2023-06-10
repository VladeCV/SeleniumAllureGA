using OpenQA.Selenium;
using SeleniumAllure.code.factoryBrowser;

namespace SeleniumAllure.SeleniumAllure.code.session
{
    public class Session
    {
        private static Session instance = null;
        private IWebDriver browser;

        private Session() {
            browser = FactoryBrowser.Make("chrome").Create();
        }
        public static Session Instance()
        {
            if (instance == null)
            {
                instance = new Session();
            }
            return instance;
        }
        public void CloseBrowser()
        {
            instance = null;
            browser.Quit();
        }

        public IWebDriver GetBrowser()
        {
            return browser;
        }

        public void ChangeFrame(String idFrame)
        {
            browser.SwitchTo().Frame(idFrame);
        }

        public void BackToPrincipal()
        {
            browser.SwitchTo().DefaultContent();
        }

    }
}
