using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    [Serializable]
    public class pGetHistoryInvoice {
        public virtual int ID { get; set; }
        public virtual double? SUM { get; set; }
        public virtual int? COUNT_BOOKING { get; set; }
        public virtual short STATUS { get; set; }
        public virtual string STATUS_STRING { get; set; }
        public virtual string INVOICEFILE { get; set; }
        public virtual int ClinetMode { get; set; }
        public virtual string DATE_CHANGE { get; set; }
        public virtual string WHO { get; set; }
        public virtual short MODE { get; set; }
        public virtual string MODE_STRING { get; set; }
        public virtual int KEY_HISTORY { get; set; }

    }
}
