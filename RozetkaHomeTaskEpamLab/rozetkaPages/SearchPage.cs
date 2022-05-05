using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace RozetkaHomeTaskEpamLab.rozetkaPages
{
    public class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Алфавитный указатель')]/parent::button/parent::div/preceding-sibling::div/input")]
        private IWebElement _searchBrandInput;

        [FindsBy(How = How.XPath, Using = "(//a[@class='checkbox-filter__link'])[3]")]
        private IWebElement _checkBox;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'buy-button')]")]
        private IWebElement _firstGood;

        [FindsBy(How = How.XPath, Using = "//rz-cart//button[contains(@class, 'header__button ng-star-inserted')]")]
        private IWebElement _cartButton;

        
        public IWebElement GetSearchBrandInput()
        {
            return _searchBrandInput;
        }
        public void SendKeysToSearchBrandInput(string brand)
        {
            _searchBrandInput.SendKeys(brand);
            
        }

        public IWebElement GetCheckBox()
        {
            return _checkBox;
        }
        public void ClickCheckBox()
        {
            Thread.Sleep(1000);
            _checkBox.Click();
        }

        public IWebElement GetFirstGood()
        {
            return _firstGood;
        }
        public void ChooseFirstGood()
        {
            _firstGood.Click();
        }

        public void ClickCartButton()
        {
            _cartButton.Click();
        }

    }
}
