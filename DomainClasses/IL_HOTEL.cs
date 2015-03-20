using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    [Serializable]
    public class IL_HOTEL {
        public virtual int id { get; set; }
        public virtual int HD_Key { get; set; }
        public virtual string HD_Unicode { get; set; }
        public virtual string HD_Name { get; set; }
        public virtual DateTime HD_UpdateDate { get; set; }
        public virtual int HD_ILKey { get; set; }
        public virtual int? HD_MTKey { get; set; }
        public virtual string HD_CityName { get; set; }
        public virtual int? HD_CTKEY { get; set; }
    }
}
