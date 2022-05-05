using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RozetkaHomeTaskEpamLab.DataSource
{
    [Serializable]
    public class Filters
    {
        public List<Filter> FiltersList { get; set; }
        public Filters()
        {
            FiltersList = new List<Filter>();
        }
    }
}
