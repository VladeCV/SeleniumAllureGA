using OpenQA.Selenium;
using SeleniumAllure.SeleniumAllure.code.control;

namespace SeleniumAllure.SeleniumAllure.code.page.Yopmail
{
    public class Inbox
    {
        public Button newMessageBtn = new Button(By.XPath("//button[@id='newmail']"));
        public Button refresInboxBtn = new Button(By.XPath("//button[@id='refresh']"));

        public Boolean emailIsDisplayed(String email)
        {
            Label userEmail = new Label(By.XPath("//*[@id='webmail']//div[text()='"+email+"']"));
            return userEmail.IsControlDisplayed();
        }

        public bool isEmailSubjectDisplayed(String subject)
        {
            Label messageSubject = new Label(By.XPath("//button//div[text()='" + subject + "']"));
            return messageSubject.IsControlDisplayed();
        }

    }
}
