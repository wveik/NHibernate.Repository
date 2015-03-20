using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class pGetKickbackByCityKey {
        public virtual int KB_KEY { get; set; }
        public virtual string HD_NAME { get; set; }
        public virtual int KB_HDKEY { get; set; }
        public virtual DateTime KB_DATE_BEGIN { get; set; }
        public virtual DateTime KB_DATE_END { get; set; }
        public virtual double KB_PROCENT { get; set; }
        public virtual DateTime KB_CREATEDATE { get; set; }
        public virtual DateTime KB_LASTUPDATE { get; set; }
        public virtual int CT_KEY { get; set; }
        public virtual string CT_NAME { get; set; }
    }
}
