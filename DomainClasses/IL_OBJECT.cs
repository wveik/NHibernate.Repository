using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class IL_OBJECT {
        public virtual int OB_Key { get; set; }
        public virtual byte[] OB_Object { get; set; }
        public virtual string OB_Name { get; set; }
        public virtual DateTime OB_UpdateDate { get; set; }
        public virtual int OB_ILKey { get; set; }
    }
}
