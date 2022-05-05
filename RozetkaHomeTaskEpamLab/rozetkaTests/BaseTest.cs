using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RozetkaHomeTaskEpamLab.rozetkaPages;
using RozetkaHomeTaskEpamLab.Utils;
using Serilog;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace RozetkaHomeTaskEpamLab.rozetkaTests
{
    [TestFixture]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    public class BaseTest
    {
        private  IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(@"E:\Projects\RozetkaHomeTaskEpamLabNew\RozetkaHomeTaskEpamLab\Logs\log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            Log.Information("Log started");      
            driver = new ChromeDriver();
            Log.Information("driver started");
            driver.Manage().Window.Maximize();
            PropertyReader propReader = new PropertyReader();
            Log.Information("going to url");
            driver.Navigate().GoToUrl(propReader.GetURL());
        }

        [TearDown]
        public void TearDown()
        {
            Log.Information("closing driver");
            driver.Quit();
            Log.Information("Log closed");
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }

        public HomePage GetHomePage()
        {
            return new HomePage(GetDriver());
           
        }

        public SearchPage GetSearchPage()
        {
            return new SearchPage(GetDriver());
            
        }

        public CartPage GetCartPage()
        {
            return new CartPage(GetDriver());
           
        }
    }
}
