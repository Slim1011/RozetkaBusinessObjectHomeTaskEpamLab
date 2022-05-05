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
    public class BrandAndCheckBox : BasePage
    {
        private const int timeToWait = 10;
        readonly IWebDriver driver;
        public BrandAndCheckBox(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void TypeBrandAndClickCheckbox( string brand)
        {
            SearchPage searchPage = new SearchPage(driver);
            searchPage.WaitElementIsEnable(timeToWait, searchPage.GetSearchBrandInput());
            searchPage.SendKeysToSearchBrandInput(brand);
            searchPage.WaitElementIsEnable(timeToWait, searchPage.GetCheckBox());
            searchPage.ClickCheckBox();
        }
    }
}
