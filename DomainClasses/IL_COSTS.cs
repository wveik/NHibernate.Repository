using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class IL_COSTS {
        public virtual int id { get; set; }
        public virtual int CTM_KEY { get; set; }
        public virtual int CTM_ILKEY { get; set; }
        public virtual int CTM_HDKEY { get; set; }
        public virtual int CTM_PNKEY { get; set; }
        public virtual int CTM_ACKEY { get; set; }
        public virtual int CTM_RTKEY { get; set; }
        public virtual int CTM_RCKEY { get; set; }
        public virtual DateTime CTM_DATE { get; set; }
        public virtual DateTime CTM_DATETO { get; set; }
        public virtual double CTM_PRICE { get; set; }
        public virtual string CTM_PRICERATE { get; set; }
        public virtual int? CTM_SPOKEY { get; set; }
        public virtual int CTM_SVKEY { get; set; }
        public virtual int CTM_TYPE { get; set; }
        public virtual string CTM_WEEK { get; set; }
        public virtual int CTM_IMPORTED { get; set; }
        public virtual short? CTM_NDAYS { get; set; }
        public virtual int CTM_TSKEY { get; set; }
        public virtual int? CTM_MinimumStay { get; set; }
        public virtual int? CTM_MaximumStay { get; set; }
        public virtual int? CTM_FreeNights { get; set; }
    }
}
