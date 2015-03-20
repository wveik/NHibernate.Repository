using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class PhoneManForInvoice {
        public virtual int PM_KEY { get; set; }
        public virtual int PM_USKEY { get; set; }
        public virtual String PM_PHONE_NUMBER { get; set; }
        public virtual int PM_GLKEY { get; set; }
        public virtual String US_USERID { get; set; }
    }
}
