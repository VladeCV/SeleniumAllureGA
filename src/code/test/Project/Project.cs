using SeleniumAllure.code.page.Todoist;

namespace SeleniumAllure.code.test.Project
{
    [TestFixture]

    public class Project : TestBase
    {
        MainPage mainPage = new MainPage();
        LoginPage loginPage = new LoginPage();
        ProjectDashboard leftMenu = new ProjectDashboard();

        [Test]
        
        public void Project_Managament() {

            //LOGIN
            mainPage.loginButton.Click();
            loginPage.emailTxtBox.SetText("vladimircvcf98@outlook.com");
            loginPage.pwdTxtBox.SetText("759153ferd123");
            loginPage.loginBtn.Click();
            Assert.IsTrue(leftMenu.todayLabel.IsControlDisplayed(), "Login was not successful");
        
            //CREATE PROJECT
            leftMenu.addProjectBtn.Click();
            leftMenu.projectName.SetText("New project blue");
            leftMenu.dropDownColorBtn.Click();
            leftMenu.projectColorBlue.Click();
            leftMenu.confirmAddition.Click();
            Thread.Sleep(1000);
            Assert.IsTrue(leftMenu.ProjectNameIsDisplayed("New project blue"), "ERROR! The project was not created");
        
            //UPDATE PROJECT
            leftMenu.ClickProjectName("New project blue");
            leftMenu.editProjectBtn.Click();
            Thread.Sleep(1000);
            leftMenu.projectName.SetText("New project red updated");
            leftMenu.dropDownColorBtn.Click();
            leftMenu.projectColorRed.Click();
            leftMenu.confirmProjectUpdate.Click();
            Assert.IsTrue(leftMenu.ProjectNameIsDisplayed("New project red updated"), "ERROR! The project was not updated");

            //DELETE PROJECT
            leftMenu.ClickProjectName("New project red updated");
            leftMenu.deleteProjectBtn.Click();
            leftMenu.deleteConfirmationBtn.Click();
            Assert.IsFalse(leftMenu.ProjectNameIsDisplayed("New project red updated"), "ERROR! The project was not deleted");

        }
    }
}
