using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class IL_RATES {
        public virtual Int16 id { get; set; }
        public virtual string IL_Code { get; set; }
        public virtual string MT_Code { get; set; }
        public virtual int IL_Key { get; set; }
        public virtual int? MT_Key { get; set; }
        public virtual DateTime IL_CREATEDATE { get; set; }
    }
}
