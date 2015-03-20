using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    [Serializable]
    public class pGetCountryFromForInvoice {
        public virtual int CN_KEY { get; set; }
        public virtual String CN_NAME { get; set; }
        public virtual String CN_NAMELAT { get; set; }
    }
}
