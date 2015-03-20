using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class VisaServiceList {
        public virtual int VSL_KEY { get; set; }
        public virtual string VSL_NAME { get; set; }
        public virtual string VSL_CODE { get; set; }
        public virtual string VSL_NAMELAT { get; set; }
        public virtual string CN_NAME { get; set; }
        public virtual int? VSL_CNKEY { get; set; }
        public virtual byte VSL_IsSupportOnly { get; set; }
        public virtual int? VSL_AGEFROM { get; set; }
        public virtual int? VSL_AGETILL { get; set; }
        public virtual short? VSL_ADULT { get; set; }
    }
}
