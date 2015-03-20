using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class IL_ACCOMODATION {
        public virtual int id { get; set; }
        public virtual int AC_Key { get; set; }
        public virtual string AC_Unicode { get; set; }
        public virtual string AC_Code { get; set; }
        public virtual string AC_Name { get; set; }
        public virtual DateTime AC_UpdateDate { get; set; }
        public virtual int AC_ILKey { get; set; }
        public virtual int? AC_MTKey { get; set; }
    }
}
