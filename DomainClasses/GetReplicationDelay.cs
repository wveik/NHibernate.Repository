using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class GetReplicationDelay {
        public virtual Int32 ID { get; set; }
        public virtual String ReplName { get; set; }
        public virtual Int32 Latency { get; set; }
    }
}
