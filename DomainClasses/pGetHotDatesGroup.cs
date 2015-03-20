using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class pGetHotDatesGroup {
        public virtual int HDG_KEY { get; set; }
        public virtual string HDG_NAME { get; set; }
        public virtual int AUTOR_KEY { get; set; }
        public virtual string AUTOR { get; set; }
        public virtual string DESCRIPTION { get; set; }

        public virtual IList<pGetHotDatesDetails> PAIRS { get; set; }
    }
}
