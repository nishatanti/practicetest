using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace practicetest.pageobject
{
    [Binding]
    public sealed class searchsteps
    {
        IWebDriver driver;
        searchRepo sr;

        [Given(@"User is On HomePage")]
        public void GivenUserIsOnHomePage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.farebuzz.com");
            driver.Manage().Window.Maximize();

        }

        [Given(@"Enter all the details of ISW")]
        public void GivenEnterAllTheDetailsOfISW(Table table)
        {
            sr = new searchRepo(driver);
            dynamic data = table.CreateDynamicInstance();
            sr.entersource((string)data.Source);
            sr.enterdestination((string)data.Destination);       
            sr.enterdeptdate();          
            sr.enterretdate();
            sr.enteradult((int)data.Adult);
            sr.enterClass((string)data.Class);
        }

        [Given(@"Click on search button")]
        public void GivenClickOnSearchButton()
        {
            sr = new searchRepo(driver);
            sr.clickbtn();
        }

        [Given(@"User is navigated to listing page")]
        public void GivenUserIsNavigatedToListingPage()
        {
            sr = new searchRepo(driver);
            sr.selectbutton();
            driver.Close();
        }

    }
}
