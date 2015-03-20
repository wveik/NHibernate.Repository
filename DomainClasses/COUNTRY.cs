using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class COUNTRY {
        public virtual Int32 CN_KEY { get; set; }
        public virtual String CN_NAME { get; set; }
        public virtual String CN_NAMELAT { get; set; }
        public virtual Int32? CN_FRAME { get; set; }
        public virtual Int32? CN_WEB { get; set; }
        public virtual String CN_WEBIMAGE { get; set; }
        public virtual String CN_WEBHTTP { get; set; }
        public virtual String CN_CODE { get; set; }
        public virtual String ROWID { get; set; }
        public virtual short CN_AnkLang { get; set; }
        public virtual Char? CN_StdKey { get; set; }
        public virtual DateTime? CN_Updatedate { get; set; }
        public virtual String CN_SMALLDESC { get; set; }
        public virtual Int32? CN_COKey { get; set; }
        public virtual String CN_NameAC { get; set; }
        public virtual Int32? CN_CNTKey { get; set; }
        public virtual Int32? CN_PASPEXPMONTH { get; set; }
        public virtual short CN_PASPEXPTYPE { get; set; }
        public virtual String cn_dep_email { get; set; }
        public virtual short cn_Accounting_type { get; set; }
        public virtual String CN_VizaRelizTime { get; set; }
        public virtual Int32 CN_VoucherType { get; set; }
    }
}
