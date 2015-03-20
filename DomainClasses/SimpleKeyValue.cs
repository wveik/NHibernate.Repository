using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class SimpleKeyValue {
        public virtual Int32 KEY { get; set; }
        public virtual String NAME { get; set; }

        public override int GetHashCode() {
            return this.KEY.GetHashCode() + this.NAME.GetHashCode();
        }
    }
}
