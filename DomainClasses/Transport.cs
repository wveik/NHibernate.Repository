using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class Transport {
        public virtual Int32 TR_KEY { get; set; }
        public virtual String TR_NAME { get; set; }
        public virtual String TR_NAMELAT { get; set; }
        public virtual short? TR_NMEN { get; set; }
        public virtual Char? TR_StdKey { get; set; }
        public virtual short? TR_StrictUsage { get; set; }
    }
}
