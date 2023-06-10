using OpenQA.Selenium;
using SeleniumAllure.code.control;

namespace SeleniumAllure.code.page.Todoist
{
    public class ProjectDashboard
    {
        //Create Project 
        public Label todayLabel = new Label(By.XPath("//div[@id='agenda_view']//header//span[text()='Today']"));
        public Button addProjectBtn = new Button(By.XPath("//div[@id='left_menu']//button[@aria-label='Add project']"));
        public TextBox projectName = new TextBox(By.XPath("//input[@name='name']"));
        public Button dropDownColorBtn = new Button(By.XPath("//form//button[@aria-haspopup='listbox']"));
        public Button projectColorRed = new Button(By.XPath("//ul//li//span[text()='Red']"));
        public Button confirmAddition = new Button(By.XPath("//form//footer//button[2]"));

        //Update Project
        public Button actionsBtn = new Button(By.XPath("//*[@id='projects_list']//li//span[text()='dasd']//following::button[@aria-label='More project actions']"));
        public Button editProjectBtn = new Button(By.XPath("//div[@class=' popper']//ul//li[4]"));
        public Button projectColorBlue = new Button(By.XPath("//ul//li//span[text()='Blue']"));
        public Button confirmProjectUpdate = new Button(By.XPath("//footer//button[2]"));

        //Delete Project
        public Button deleteProjectBtn = new Button(By.XPath("//div[@class=' popper']//ul//li[13]"));
        public Button deleteConfirmationBtn = new Button(By.XPath("//footer//button[2]"));
        public Label moreActionsButton = new Label(By.XPath("//a[@aria-label='asd, 0 tasks']//following-sibling::div//button"));

        public bool ProjectNameIsDisplayed(String projectName)
        {
            Label labelProjectName = new Label(By.XPath("//ul[@id='projects_list']//li[last()]//span[text()='"+projectName+"']"));
            return labelProjectName.IsControlDisplayed();
        }
        public void ClickProjectName(String projectName)
        {
            Label moreActionsButton = new Label(By.XPath("//a[@aria-label='"+projectName+", 0 tasks']//following-sibling::div//button"));
            moreActionsButton.Click();
        }
    }
}
