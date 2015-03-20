using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    [Serializable]
    public class pGetCountryForProgram {
        public virtual int CN_KEY { get; set; }
        public virtual String CN_CODE { get; set; }
        public virtual String CN_NAME { get; set; }
        public virtual String CN_NAMELAT { get; set; }
        public virtual String VISA { get; set; }
        public virtual String ACTIVE { get; set; }
        public virtual int cn_Accounting_type { get; set; }
        public virtual int CN_Disabled { get; set; }
        public virtual String WEB_COUNTRY { get; set; }
        public virtual int cn_id { get; set; }
    }
}
