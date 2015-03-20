using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    [Serializable]
    public class pGetInvoiceDetails {
        public virtual Int32 DL_KEY { get; set; }
        public virtual Int32? BIS_DLKEY { get; set; }
        public virtual Int32? BIS_BIKEY { get; set; }
        public virtual String DG_CODE { get; set; }
        public virtual String DL_NAME { get; set; }
        public virtual Double? DL_COST { get; set; }
        public virtual Double? BIS_SUMBYBILL { get; set; }
        public virtual Double BIS_SUMCOMM { get; set; }
        public virtual short BIS_CALL_BACK { get; set; }
        public virtual int CANCEL { get; set; }
        public virtual Boolean Flag { get; set; }
        public virtual Double? FN_BIS_SUMBYBILL { get; set; }
    }
}
