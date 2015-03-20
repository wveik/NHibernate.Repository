using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class pGetDetailsForBurn {
        public virtual int ID { get; set; }
        public virtual string DATE { get; set; }
        public virtual string FLIGHT { get; set; }
        public virtual string CLASS { get; set; }
        public virtual int PLACES { get; set; }
        public virtual int BUSY { get; set; }
        public virtual int FREE { get; set; }
        public virtual int WAIT { get; set; }
    }
}
