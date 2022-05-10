using OpenQA.Selenium;
using RozetkaHomeTaskEpamLab.Decorator;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RozetkaHomeTaskEpamLab.rozetkaPages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            
        }

        [FindsBy(How = How.XPath, Using = "//input[contains(@class, 'search-form__input ng-')]")]
        private IWebElement _searchInput;
        [FindsBy(How = How.XPath, Using = "//button[contains(@class, 'button button_color_green')]")]
        private IWebElement _searchButton;

        DecoratedSendKeys sendKeysToSearchInput => new DecoratedSendKeys(_searchInput);
        DecoratedClick decoratedClick => new DecoratedClick(_searchButton);

        public void SendKeysToSearchInput(string typeOfGood)
        {
            sendKeysToSearchInput.SendKeys(typeOfGood);
           
        }

        public void ClickSearhcButton()
        {
            decoratedClick.Click();
            
        }
    }
}
