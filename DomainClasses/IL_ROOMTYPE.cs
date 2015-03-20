using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class IL_ROOMTYPE {
        public virtual int id { get; set; }
        public virtual int RT_Key { get; set; }
        public virtual string RT_Unicode { get; set; }
        public virtual string RT_Code { get; set; }
        public virtual string RT_Name { get; set; }
        public virtual DateTime RT_UpdateDate { get; set; }
        public virtual int RT_ILKey { get; set; }
        public virtual int? RT_MTKey { get; set; }
    }
}
