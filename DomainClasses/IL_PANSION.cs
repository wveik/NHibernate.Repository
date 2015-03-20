using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class IL_PANSION {
        public virtual int id { get; set; }
        public virtual int PN_Key { get; set; }
        public virtual string PN_Code { get; set; }
        public virtual string PN_Name { get; set; }
        public virtual DateTime PN_UpdateDate { get; set; }
        public virtual int PN_ILKey { get; set; }
        public virtual int? PN_MTKey { get; set; }
    }
}
