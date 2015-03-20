using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class IL_STOPSALELIST {
        public virtual int id { get; set; }
        public virtual int SSL_KEY { get; set; }
        public virtual int SSL_HDKEY { get; set; }
        public virtual int SSL_RCKEY { get; set; }
        public virtual int SSL_RTKEY { get; set; }
        public virtual DateTime SSL_DATEBEGIN { get; set; }
        public virtual DateTime SSL_DATEEND { get; set; }
        public virtual int SSL_PRKEY { get; set; }
        public virtual short? SSL_RELPERIOD { get; set; }
        public virtual short SSL_CANCELLED { get; set; }
        public virtual DateTime SSL_CREATEDATE { get; set; }
        public virtual int SSL_ILKey { get; set; }
        public virtual int? MT_HDKey { get; set; }
        public virtual int? MT_RMKey { get; set; }
        public virtual int? MT_RCKey { get; set; }
        public virtual short? StatusID { get; set; }
    }
}
