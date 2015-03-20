using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class PhoneMan {
        public virtual Int32 PM_KEY { get; set; }
        public virtual Int32 PM_USKEY { get; set; }
        public virtual String PM_PHONE_NUMBER { get; set; }
        public virtual Int32 PM_GLKEY { get; set; }
    }
}
