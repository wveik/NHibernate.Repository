using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.Classes {
    public class InnerContainer {
        public string Name { get; set; }
        public IList<pGetHotDates> data;
    }
}
