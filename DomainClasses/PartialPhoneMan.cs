using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class PartialPhoneMan {
        public virtual Int32 PM_KEY { get; set; }
        public virtual Int32 PM_USKEY { get; set; }
        public virtual String PM_PHONE_NUMBER { get; set; }
        public virtual String US_USERID { get; set; }
        public virtual String US_SUBSIDIARY { get; set; }
        public virtual String US_NAME { get; set; }
        public virtual String GL_PHONE_NUMBER { get; set; }
        public virtual String CT_NAME { get; set; }
        public virtual Int32 CT_KEY { get; set; }
    }
}
