using OpenQA.Selenium;
using RozetkaHomeTaskEpamLab.Decorator;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RozetkaHomeTaskEpamLab.rozetkaPages
{
    public class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//div[@class='cart-receipt__sum-price']/span")]
        private IWebElement _priceWindow;

        DecoratedGetText safeGetPrice => new DecoratedGetText(_priceWindow);
        public IWebElement GetPriceWindow()
        {
            return _priceWindow; 
        }

        public int GetTextFromPriceWindow()
        {
           return int.Parse(safeGetPrice.SafeGetText());
        }
        
    }
}
