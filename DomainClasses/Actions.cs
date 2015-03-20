using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class Actions {
        public virtual Int32 AC_Key { get; set; }
        public virtual String AC_Name { get; set; }
        public virtual Char? AC_Description { get; set; }
        public virtual String AC_CUSTOMSCRIPT { get; set; }
    }
}
