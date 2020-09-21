using NUnit.Framework;
using OpenQA.Selenium;
using practicetest.utility;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace practicetest.pageobject
{
    class searchRepo
    {
        IWebDriver driver;
        Support supp = new Support();

        public searchRepo(IWebDriver driver)
        {          
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        [FindsBy(How = How.Id,Using = "")]

        [FindsBy(How = How.CssSelector, Using = "#txtAirFrom")]
        public IWebElement txtSource { get; set; }

        public void entersource(string source)
        {
            txtSource.SendKeys(source);
        }

        [FindsBy(How = How.CssSelector, Using = "#txtAirTo")]

        public IWebElement txtDestination { get; set; }
        public void enterdestination(string destination)
        {
            txtDestination.SendKeys(destination);
            txtDestination.SendKeys(Keys.Tab);
        }

        [FindsBy(How = How.Id, Using = "txtAirDepDate")]

        public IWebElement txtDeptDate { get; set; }
        public void enterdeptdate()
        {
            txtDeptDate.Click();
            txtDeptDate.Clear();
            txtDeptDate.SendKeys("09/24/2020");           
        }

        [FindsBy(How = How.Id, Using = "txtAirRetDate")]

        public IWebElement txtRetDate { get; set; }
        public void enterretdate()
        {
            
            txtRetDate.Clear();
            txtRetDate.SendKeys("09/27/2020");
            txtRetDate.SendKeys(Keys.Tab);
        }

        [FindsBy(How = How.Id, Using = "ddlAirAdults")]

        public IWebElement ddlAdults { get; set; }
        public void enteradult(int adult)
        {
            ddlAdults.Click();
            string adults = adult.ToString();
            ddlAdults.SendKeys(adults);
        }

        [FindsBy(How = How.Id, Using = "ddlAirClass")]

        public IWebElement ddlClass { get; set; }
        public void enterClass(string Class)
        {
            ddlClass.SendKeys(Class);
        }

        [FindsBy(How = How.CssSelector, Using = "#div1 > div.btn-main > div > button")]


        public IWebElement btnSearch { get; set; }
        public void clickbtn()
        {
            btnSearch.Click();
        }

        [FindsBy(How = How.XPath, Using = "//button[@class='cta-1st select__cta']")]

        public IWebElement ShowButton { get; set; }
        public void selectbutton()
        {
            supp.ExplicitWaitElement(40, driver, ShowButton);
            Assert.IsTrue(ShowButton.Displayed);

            //IWebElement ele = driver.FindElement(By.XPath("//button[@class='cta-1st select__cta']"));
            //Assert.IsTrue(ele.Displayed);
        }
    }
}
