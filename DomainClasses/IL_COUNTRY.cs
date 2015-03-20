using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class IL_COUNTRY {
        public virtual int CN_KEY { get; set; }
        public virtual int CN_ILKEY { get; set; }
        public virtual string CN_NAME { get; set; }
        public virtual string CN_CODE { get; set; }
        public virtual int CN_MTKEY { get; set; }
        public virtual DateTime CN_CREATEDATE { get; set; }
    }
}
