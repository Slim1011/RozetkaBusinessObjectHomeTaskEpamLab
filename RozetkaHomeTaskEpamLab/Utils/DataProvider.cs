using RozetkaHomeTaskEpamLab.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozetkaHomeTaskEpamLab.Utils
{
    public class DataProvider
    {
        public static IEnumerable<Filter> TestData()
        {

            Filters filters = FilterReader.ReadFiltersFromXML();
            System.Console.WriteLine("filters:" + filters.ToString());
            for (int i = 0; i < filters.FiltersList.Count; i++)
            {
                yield return filters.FiltersList[i];
            }
        }
    }
}
