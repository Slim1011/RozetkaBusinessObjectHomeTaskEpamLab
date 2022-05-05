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
    public class CategoryOfGood : BasePage
    {
        readonly IWebDriver driver;
        public CategoryOfGood(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void ChooseCategoryOfGoodAndClick( string categoryOfGoods)
        {
            HomePage homePage = new HomePage(driver);
            homePage.SendKeysToSearchInput(categoryOfGoods);
            homePage.ClickSearhcButton();
        }
    }
}
