using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class pGetInvoiceByIdPartner {
        public virtual String No { get; set; }
        public virtual String Type { get; set; }
        public virtual String CreationDate { get; set; }
        public virtual String StartDate { get; set; }
        public virtual String Creator { get; set; }
        public virtual Double? Sum { get; set; }
        public virtual String Rate { get; set; }
        public virtual String Count { get; set; }
        public virtual String Status { get; set; }
        public virtual String Comment { get; set; }
        public virtual String FileName { get; set; }
        public virtual Int32 StatusId { get; set; }
    }
}
