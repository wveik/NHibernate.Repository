using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    [Serializable]
    public class pGetResourseForInvoice {

        public virtual int ID_ResultTable { get; set; } 
        public virtual String DG_CODE { get; set; } 
        public virtual String DG_TURDATE { get; set; }  
        public virtual int Duration { get; set; }
        public virtual String DG_CRDATE { get; set; }
        public virtual String Tourists { get; set; }
        public virtual String DL_NAME { get; set; }
        public virtual String AnotherResourse { get; set; }
        public virtual String Ann { get; set; }
        public virtual String InInvoices { get; set; }
        public virtual int Check_ { get; set; }
        public virtual int DL_KEY { get; set; }

        public virtual Boolean Check { get; set; }
        public virtual Boolean Delete { get; set; }

    }
}
