using SeleniumAllure.SeleniumAllure.code.page.Yopmail;
using SeleniumAllure.SeleniumAllure.code.session;
using TechTalk.SpecFlow;

namespace SeleniumAllure.SeleniumAllure.Steps
{
    [Binding]
    public class SendEmail
    {
        MainPage mainPage = new MainPage();
        Inbox inboxPage = new Inbox();
        EmailBody emailBody = new EmailBody();
        
        public static string generatePhrase()
        {
            Random random = new Random();
            string[] adjectives = { "beautiful", "mysterious", "energetic", "brilliant", "vibrant", "sad", "marvelous" };
            string[] nouns = { "sunrise", "adventure", "dream", "journey", "harmony", "moonlight", "sunset" };

            return $"{adjectives[random.Next(adjectives.Length)]} {nouns[random.Next(nouns.Length)]}";
        }
        string randomPhrase = generatePhrase();

        [Given(@"I have access to yopmail\.com")]
        public void GivenIHaveAccessToYopmail_Com()
        {
            Session.Instance().GetBrowser().Navigate().GoToUrl("https://yopmail.com/");
        }

        [When(@"I put my credentials")]
        public void WhenIPutMyCredentials()
        {
            mainPage.emailInput.SetText("paemaslls");
            mainPage.checkInboxBtn.Click();
        }

        [Then(@"I should be on my inbox")]
        public void ThenIShouldBeOnMyInbox()
        {
            Assert.IsTrue(inboxPage.emailIsDisplayed("paemaslls@yopmail.com"), "Login was not successful");
        }

        [Given(@"I click on new email and set the data for the mail")]
        public void GivenIClickOnNewEmailAndSetTheDataForTheMail()
        {
           
            inboxPage.newMessageBtn.Click();
            Session.Instance().ChangeFrame("ifmail");
            emailBody.recipientInput.SetText("paemaslls@yopmail.com");
            emailBody.subjectInput.SetText(randomPhrase);
            emailBody.messageBody.SetText("Body message for email testing");
        }

        [When(@"I click on send button")]
        public void WhenIClickOnSendButton()
        {
            emailBody.sendMessageBtn.Click();
        }

        [Then(@"I should see a email was sent message")]
        public void ThenIShouldSeeAEmailWasSentMessage()
        {
            Assert.IsTrue(emailBody.messageSentAlert.IsControlDisplayed(), "Email was not sent!!!");
            
        }

        [Given(@"I change to my inbox")]
        public void GivenIChangeToMyInbox()
        {
            Session.Instance().BackToPrincipal();
        }

        [When(@"I click on refresh button")]
        public void WhenIClickOnRefreshButton()
        {
            inboxPage.refresInboxBtn.Click();
            Session.Instance().ChangeFrame("ifinbox");
        }

        [Then(@"I should see the email subject")]
        public void ThenIShouldSeeTheEmailSubject()
        {
            //Assert.IsTrue(inboxPage.isEmailSubjectDisplayed(randomPhrase), "Email not found");
            Session.Instance().BackToPrincipal();
            inboxPage.refresInboxBtn.Click();
            Session.Instance().CloseBrowser();
        }

    }
}
