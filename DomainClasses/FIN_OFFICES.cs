using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class FIN_OFFICES {
        public virtual Int32 OF_KEY { get; set; }
        public virtual Int32 OF_FRKEY { get; set; }
        public virtual String OF_DESCRIPTION { get; set; }
        public virtual String OF_NAME { get; set; }
        public virtual short OF_ISFOLDER { get; set; }
        public virtual Int32 OF_PARENT { get; set; }
        public virtual Int32? OF_DSKEY { get; set; }
        public virtual Int32? OF_CTKEY { get; set; }
        public virtual Int32? OF_MAIN { get; set; }
        public virtual String OF_ADDRESS { get; set; }
        public virtual short? OF_HotCenter { get; set; }
        public virtual short OF_ISFRANCH { get; set; }
        public virtual String OF_PHONE { get; set; }
        public virtual String OF_CODE { get; set; }
        public virtual String OF_SYSDATA { get; set; }
        public virtual Int32? OF_ENTKEY { get; set; }
        public virtual short OF_ROOTOFFICE { get; set; }
        public virtual Int32? OF_RootMainOffice { get; set; }
        public virtual String Subway { get; set; }
    }
}
