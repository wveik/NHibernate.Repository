using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    [Serializable]
    public class IL_ROOMCATEGORY {
        public virtual int id { get; set; }
        public virtual int RC_Key { get; set; }
        public virtual string RC_Unicode { get; set; }
        public virtual string RC_Name { get; set; }
        public virtual DateTime RC_UpdateDate { get; set; }
        public virtual int RC_ILKey { get; set; }
        public virtual int? RC_MTKey { get; set; }
    }
}
