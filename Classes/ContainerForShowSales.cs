using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.Classes {
    public class ContainerForShowSales<T> {
        public string Name { get; set; }
        public List<string> Dates { get; set; }
        public List<Container_pShowSalesForPeriod> List { get; set; }
        public IList<LineChart> Chart { get; set; }
        public T Data { get; set; }
    }
}
