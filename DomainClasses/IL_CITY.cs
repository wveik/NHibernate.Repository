using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class IL_CITY {
        public virtual int CT_KEY { get; set; }
        public virtual int CT_ILKEY { get; set; }
        public virtual string CT_NAME { get; set; }
        public virtual string CT_CODE { get; set; }
        public virtual int CT_MTKEY { get; set; }
        public virtual int? CT_CNKEY { get; set; }
    }
}
