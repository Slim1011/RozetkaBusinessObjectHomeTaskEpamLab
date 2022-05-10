using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;



namespace RozetkaHomeTaskEpamLab.rozetkaPages
{
    public class BasePage
    {
        protected IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//select[@_ngcontent-rz-client-c184]")]
        private IWebElement _sortDropdownMenu;

        public void WaitForPageLoad(int timeToWait)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeToWait));
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ImplicitWait(int timeToWait)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeToWait);
        }

        public void WaitVisibilityOfElement(int timeToWait, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeToWait));
            wait.Until(driver => element.Displayed);
        }

        public void WaitElementIsEnable(int timeToWait, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeToWait));
            wait.Until(driver => element.Displayed && element.Enabled);
        }
        public void checkSortOfPriceFromDropdownMenu(string typeOfSort)
        {
            var selectElement = new SelectElement(_sortDropdownMenu);
            selectElement.SelectByText(typeOfSort);
        }
    }
}
