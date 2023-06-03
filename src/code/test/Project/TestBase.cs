using SeleniumAllure.code.session;

namespace SeleniumAllure.code.test.Project
{
    [TestFixture]
    public class TestBase
    {
        [SetUp]
        public void OpenBrowser()
        {
            Session.Instance().GetBrowser().Navigate().GoToUrl("https://todoist.com/");
        }

        [TearDown]
        public void CloseBrowser()
        {
            Session.Instance().CloseBrowser();
        }
    }
}
