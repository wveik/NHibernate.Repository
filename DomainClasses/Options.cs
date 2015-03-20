using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class Options {
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual string value { get; set; }
        public virtual int IL_Key { get; set; }
        public virtual DateTime? value_date { get; set; }
    }
}
