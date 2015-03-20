using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.Classes {
    public class ContainerShowSaleSecond {
        public IList<pShowSalesForPeriod> list { get; set; }
        public bool flag { get; set; }
        public string message { get; set; }
    }
}
