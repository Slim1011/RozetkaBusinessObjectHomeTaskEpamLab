using NUnit.Framework;
using RozetkaHomeTaskEpamLab.BusinessObject;
using RozetkaHomeTaskEpamLab.DataSource;
using RozetkaHomeTaskEpamLab.rozetkaPages;
using RozetkaHomeTaskEpamLab.Utils;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
[assembly: LevelOfParallelism(3)]

namespace RozetkaHomeTaskEpamLab.rozetkaTests
{
    [TestFixture]

    [Parallelizable(scope: ParallelScope.All)]
    class VerifyThatBucketContainsGoodAndPriceIsCorrectTest : BaseTest
    {
      
        [Test]
        [TestCaseSource(typeof(DataProvider), nameof(DataProvider.TestData))]

        public void VerifyThatBucketContainsGoodWithCorrectPriceTest(Filter filter)
        {
            Log.Information("Test started.");
            Log.Information($"Test parameters: category = {filter.TypeOfGood}, brand = {filter.Brand}, type of sort = {filter.TypeOfSort}");
            try
            { 
                CategoryOfGood CategoryOfGood = new(GetDriver());
                CategoryOfGood.ChooseCategoryOfGoodAndClick(filter.TypeOfGood);
                BrandAndCheckBox BrandAndCheckBox = new(GetDriver());
                BrandAndCheckBox.TypeBrandAndClickCheckbox(filter.Brand);
                TypeOfSortAndFirstGood typeOfSortAndFirstGood = new(GetDriver());
                typeOfSortAndFirstGood.ChooseTypeOfSOrtAndOrderFirstGood(filter.TypeOfSort);
                GetGoodPrice getGoodPrice = new(GetDriver());
                Assert.IsTrue(getGoodPrice.GetPriceOfGood() < filter.PriceLimit);

                Log.Information("Test succesfull.");
            }
            catch (Exception ex)
            {

                Log.Error($"Test failed: {ex.Message}");
            }

            
        }
    }
}
