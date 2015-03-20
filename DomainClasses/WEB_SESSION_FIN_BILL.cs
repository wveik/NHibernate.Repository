using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class WEB_SESSION_FIN_BILL {
        public virtual Int32 WSFB_KEY { get; set; }
        public virtual String WSFB_USER { get; set; }
        public virtual String WSFB_IP_ADDRESS { get; set; }
        public virtual DateTime WSFB_DATE_TIME_CREATE { get; set; }
        public virtual DateTime WSFB_DATE_TIME_LAST_UPDATE { get; set; }
        public virtual Int32 WSFB_BI_KEY { get; set; }
    }
}
