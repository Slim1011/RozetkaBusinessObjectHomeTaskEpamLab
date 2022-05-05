using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozetkaHomeTaskEpamLab.DataSource
{
    [Serializable]
    public class Filter
    {
        public string TypeOfGood { get; set; }
        public string Brand { get; set; }
        public string TypeOfSort { get; set; }
        public int PriceLimit { get; set; }
    }
}
