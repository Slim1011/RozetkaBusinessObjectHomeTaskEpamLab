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
    public class TypeOfSortAndFirstGood : BasePage
    {
        private const int timeToWait = 10;
        readonly IWebDriver driver;
        public TypeOfSortAndFirstGood(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void ChooseTypeOfSOrtAndOrderFirstGood(string sortType)
        {
            SearchPage searchPage = new SearchPage(driver);
            searchPage.checkSortOfPriceFromDropdownMenu(sortType);
            searchPage.WaitElementIsEnable(timeToWait, searchPage.GetFirstGood());
            searchPage.ChooseFirstProduct();
            searchPage.ClickCartButton();
        }
    }
}
