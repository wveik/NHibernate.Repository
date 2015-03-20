using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class pGetFullInfoMobile {
        public virtual int RT_ID { get; set; }
        public virtual string DG_CODE { get; set; }
        public virtual string DG_MAINMEN { get; set; }
        public virtual int COUNT_TURISTS { get; set; }
        public virtual string DATE_TRAVEL { get; set; }
        public virtual string CN_NAME { get; set; }
        public virtual string CT_NAME { get; set; }
        public virtual string HD_NAME { get; set; }
        public virtual string INSURE { get; set; }
        public virtual int RATING { get; set; }
    }
}
