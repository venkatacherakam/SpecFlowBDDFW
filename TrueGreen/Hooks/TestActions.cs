using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TruGreen.Hooks
{
    public class TestActions : BaseWebPage
    {
        By _myAccount = By.XPath("//div[@data-testid='my-accounts-container']//img");
        By _addContactButton = By.XPath("//span[text()='Add contact']");
        By _addFirstNameInput = By.XPath("//input[contains(@name,'firstName')]");
        By _addLastNameInput = By.XPath("//input[contains(@name,'lastName')]");
        By _addEmailInput = By.XPath("//input[@type='email']");
        By _addJobTitleInput = By.XPath("//input[contains(@name,'jobTitle')]");
        By _saveButton = By.XPath("//button[@type='submit']/span");
        By _userName = By.XPath("//input[@id='username']");
        By _password = By.XPath("//input[@id='password']");
        By _loginButton = By.XPath("//button[@type='submit']");



        private IWebDriver driver;
        public TestActions()
        {
            driver = WebDriverManager.Instance.GetDriver();
        }

        public void LoginToCRM()
        {
            GoTo();
            SendText(_userName, GlobalPage.GetGlobal().LoginUserName);
            SendText(_password, GlobalPage.GetGlobal().LoginPassword);
            ClickElement(_loginButton);


        }
        public void NavigateMyContacts()
        {

            ClickElement(_myAccount);
        }

        public void OpenNewContactWindow()
        {
            ClickElement(_addContactButton);
        }

        public void EnterNewContactDetails()
        {
            SendText(_addEmailInput, GlobalPage.GetGlobal().email);
            SendText(_addFirstNameInput, GlobalPage.GetGlobal().firstName);
            SendText(_addLastNameInput, GlobalPage.GetGlobal().lastName);
            SendText(_addJobTitleInput, GlobalPage.GetGlobal().jobTitle);
        }

        public void SaveTheNewContact()
        {
            ClickElement(_saveButton);
        }

        public void ValidateTheCreatedLead()
        {
            Console.WriteLine("Lead Created Successfully");
        }
    }
}
