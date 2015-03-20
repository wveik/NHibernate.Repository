using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class TopicCall {
        public virtual Int32 TC_KEY { get; set; }
        public virtual String TC_TEXT { get; set; }
        public virtual String TC_COMMENT { get; set; }
        public virtual short TC_TYPE_INN { get; set; }
        public virtual short TC_TYPE_OUT { get; set; }
        public virtual short TC_HIDE { get; set; }
        public virtual DateTime TC_DATE { get; set; }
        public virtual Int32? TC_OWNER { get; set; }
        public virtual String TC_WHO { get; set; }
    }
}
