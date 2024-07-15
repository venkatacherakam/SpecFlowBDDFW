using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TruGreen.Steps
{
    [Binding]
    public sealed class TestSteps
    {
       // private IWebDriver driver;
        [Given(@"Log into the CRM application\.")]
        public void GivenLogIntoTheCRMApplication_()
        {

            Pages.Page.TestActions.LoginToCRM();

        }

        [Given(@"Navigate to the Contacts section\.")]
        public void GivenNavigateToTheContactsSection_()
        {

            Pages.Page.TestActions.NavigateMyContacts();


        }

        [Given(@"Click on the ‘New Contact’ button\.")]
        public void GivenClickOnTheNewContactButton_()
        {
            Pages.Page.TestActions.OpenNewContactWindow();
        }

        [When(@"Enter all mandatory fields with valid data")]
        public void WhenEnterAllMandatoryFieldsWithValidData()
        {
            Pages.Page.TestActions.EnterNewContactDetails();
        }

        [When(@"Save the new contact\.")]
        public void WhenSaveTheNewContact_()
        {
            Pages.Page.TestActions.SaveTheNewContact();
        }

        [Then(@"The contact should create")]
        public void ThenTheContactShouldCreate()
        {
            Pages.Page.TestActions.ValidateTheCreatedLead();
        }

    }
}
