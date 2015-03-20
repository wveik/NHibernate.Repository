using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class fGetRangeWidth {
        public virtual int ID { get; set; }
        public virtual int? COUNT_FROM { get; set; }
        public virtual int? COUNT_TILL { get; set; }
    }
}
