using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class pGetHotDatesDetails {
        public virtual int HDGD_KEY { get; set; }
        public virtual string NAME { get; set; }
        public virtual int HDGD_CITY_FROM { get; set; }
        public virtual int HDGD_CITY_TILL { get; set; }
        public virtual int HDGD_HDG_KEY { get; set; }
        public virtual int? HDGD_ORDER { get; set; }
    }

}
