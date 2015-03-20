using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class pGetHotelsGroup {
        public virtual Int32 HG_KEY { get; set; }
        public virtual String HG_NAME { get; set; }
        public virtual Int32 HG_CNKEY { get; set; }
        public virtual String CN_NAME { get; set; }
        public virtual DateTime HG_CREATE_DATE { get; set; }
        public virtual DateTime HG_LAST_UPDATE { get; set; }
        public virtual short HG_HIDE { get; set; }
    }
}
