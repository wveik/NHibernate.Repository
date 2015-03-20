using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class HotDatesGroupDetails {
        public virtual Int32 HDGD_KEY { get; set; }
        public virtual Int32 HDGD_CITY_FROM { get; set; }
        public virtual Int32 HDGD_CITY_TILL { get; set; }
        public virtual Int32 HDGD_HDG_KEY { get; set; }
        public virtual Int32? HDGD_ORDER { get; set; }
    }
}
