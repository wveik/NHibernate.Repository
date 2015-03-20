using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.Classes {
    public class LineChart {
        public string name { get; set; }
        public int?[] data { get; set; }
    }
}
