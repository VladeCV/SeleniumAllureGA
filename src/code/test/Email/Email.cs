using SeleniumAllure.code.page.Yopmail;
using SeleniumAllure.code.session;

namespace SeleniumAllure.code.test.Email
{
    [TestFixture]
    public class Email : TestBase
    {
        MainPage mainPage = new MainPage();
        Inbox inboxPage = new Inbox();
        EmailBody emailBody = new EmailBody();

        [Test]

        public void enterEmail()
        {
            //GENERATE A RANDOM PHRASE FOR MESSAGE BODY
            string[] adjectives = { "beautiful", "mysterious", "energetic", "brilliant", "vibrant", "sad", "marvelous" };
            string[] nouns = { "sunrise", "adventure", "dream", "journey", "harmony", "moonlight", "sunset" };

            Random random = new Random();
            string randomPhrase = $"{adjectives[random.Next(adjectives.Length)]} {nouns[random.Next(nouns.Length)]}";

            //LOGIN TO EMAIL
            mainPage.emailInput.SetText("paemaslls");
            mainPage.checkInboxBtn.Click();
            Assert.IsTrue(inboxPage.emailIsDisplayed("paemaslls@yopmail.com"), "Login was not successful");

            //CREATE EMAIL AND SEND IT
            inboxPage.newMessageBtn.Click();
            Session.Instance().ChangeFrame("ifmail"); 
            emailBody.recipientInput.SetText("paemaslls@yopmail.com");
            emailBody.subjectInput.SetText(randomPhrase);
            emailBody.messageBody.SetText("Body message for email testing");
            emailBody.sendMessageBtn.Click();
            Assert.IsTrue(emailBody.messageSentAlert.IsControlDisplayed(),"Email was not sent!!!");
            Session.Instance().BackToPrincipal();
            
            //CHECK INBOX
            inboxPage.refresInboxBtn.Click();
            Session.Instance().ChangeFrame("ifinbox");
            Assert.IsTrue(inboxPage.isEmailSubjectDisplayed(randomPhrase), "Email not found");
            Session.Instance().BackToPrincipal();
            inboxPage.refresInboxBtn.Click();
        }

    }
}
