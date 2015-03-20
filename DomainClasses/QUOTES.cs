using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class QUOTES {
        public virtual Int32 QT_KEY { get; set; }
        public virtual Int32 QT_SVKEY { get; set; }
        public virtual Int32 QT_CODE { get; set; }
        public virtual Int32 QT_SUBCODE1 { get; set; }
        public virtual Int32 QT_SUBCODE2 { get; set; }
        public virtual Int32 QT_PRKEY { get; set; }
        public virtual Int32 QT_AGENT { get; set; }
        public virtual DateTime? QT_DATE { get; set; }
        public virtual short? QT_BYCHECKIN { get; set; }
        public virtual short? QT_BYROOM { get; set; }
        public virtual short? QT_PLACES { get; set; }
        public virtual short? QT_RELEASE { get; set; }
        public virtual Int32? QT_OWNER { get; set; }
        public virtual DateTime? QT_CREATEDATE { get; set; }
        public virtual Int32? QT_BUSY { get; set; }
        public virtual short? QT_Type { get; set; }
        public virtual short? QT_PayTerm { get; set; }
        public virtual DateTime? QT_LastUpdate { get; set; }
        public virtual Int32? QT_ILQTKEY { get; set; }
        public virtual Int32? QT_ILKEY { get; set; }
        public virtual Int32? QT_FREE_PUBLIC { get; set; }
        public virtual Int32? QT_SMALL_LIMIT { get; set; }
        public virtual Int32? QT_FAST_LIMIT { get; set; }
        public virtual Int32? QT_TICKET_FREE_LIMIT { get; set; }
    }
}
