using OpenQA.Selenium;
using RozetkaHomeTaskEpamLab.rozetkaPages;
using RozetkaHomeTaskEpamLab.rozetkaTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozetkaHomeTaskEpamLab.BusinessObject
{
    public class GetGoodPrice : BasePage
    {
        private const int timeToWait = 10;
        readonly IWebDriver driver;
        public GetGoodPrice(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public int GetPriceOfGood()
        {
            CartPage cartPage = new CartPage(driver);
            cartPage.WaitVisibilityOfElement(timeToWait, cartPage.GetPriceWindow());
            return cartPage.GetTextFromPriceWindow();
        }
    }
}
