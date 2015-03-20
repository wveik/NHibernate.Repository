using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class RIV_CALCTASK_STATE {
        public virtual Int32 TS_KEY { get; set; }
        public virtual Int32 TS_ITEM { get; set; }
        public virtual Int32 CST_CTKEY { get; set; }
        public virtual DateTime? CST_HDCLC_START { get; set; }
        public virtual DateTime? CST_HDCLC_NOW { get; set; }
        public virtual String CST_HDCLC_MESS { get; set; }
        public virtual DateTime? CST_SRVCLC_START { get; set; }
        public virtual DateTime? CST_SRVCLC_NOW { get; set; }
        public virtual String CST_SRVCLC_MESS { get; set; }
        public virtual DateTime? CST_BOOKKEY_START { get; set; }
        public virtual DateTime? CST_BOOKKEY_NOW { get; set; }
        public virtual String CST_BOOKKEY_MESS { get; set; }
        public virtual DateTime? CST_FILLHEAD_START { get; set; }
        public virtual DateTime? CST_FILLHEAD_NOW { get; set; }
        public virtual String CST_FILLHEAD_MESS { get; set; }
        public virtual Int32? CST_BOOKKEY_COUNT { get; set; }
        public virtual Int32? CST_HDCLC_COUNT { get; set; }
        public virtual Int32? CST_SRVCLC_COUNT { get; set; }
        public virtual Int32? CST_FILLHEAD_COUNT { get; set; }
    }
}
