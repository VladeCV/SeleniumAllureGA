using OpenQA.Selenium;
using SeleniumAllure.code.control;

namespace SeleniumAllure.code.page.Yopmail
{
    public class EmailBody
    {
        public TextBox recipientInput = new TextBox(By.XPath("//input[@id='msgto']"));
        public TextBox subjectInput = new TextBox(By.XPath("//input[@id='msgsubject']"));
        public TextBox messageBody = new TextBox(By.XPath("//div[@id='msgbody']"));
        public Button sendMessageBtn = new Button(By.XPath("//button[@id='msgsend']"));
        public Label messageSentAlert = new Label(By.XPath("//div[text()='Your message has been sent']"));
    }
}
