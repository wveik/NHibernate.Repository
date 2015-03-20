using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class pGetFullSumOfBookingInvoice {
        public virtual Int32 FSBI_KEY { get; set; }
        public virtual Int32 FSBI_BI_DOCKEY { get; set; }
        public virtual String FSBI_DG_CODE { get; set; }
        public virtual Double FSBI_BIS_SUMBYBILL { get; set; }
        public virtual Double? FSBI_BIS_SUMCOMM { get; set; }
        public virtual short? FSBI_BIS_CALL_BACK { get; set; }
        public virtual Int32 BI_KEY { get; set; }
    }
}
