using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class pGetReportTimingTheTask {
        public virtual Int32 ID { get; set; }
        public virtual DateTime TS_CREATEDATE { get; set; }
        public virtual DateTime TS_NEXTRUNTIME { get; set; }
        public virtual string FROM_COUNTRY { get; set; }
        public virtual string TILL_COUNTRY { get; set; }
        public virtual string TYPE_TASK { get; set; }
        public virtual string RANGE_TASK { get; set; }
        public virtual DateTime START_CALC { get; set; }
        public virtual DateTime FINISH_CALC { get; set; }
        public virtual int TS_KEY { get; set; }
        public virtual int CT_Weight { get; set; }
        public virtual int CST_BOOKKEY_COUNT { get; set; }        		


        public virtual TimeSpan WAITING_TIME {
            get {
                return (START_CALC - TS_NEXTRUNTIME);
            }
        }
        public virtual TimeSpan CALC_TIME {
            get {
                return (FINISH_CALC - START_CALC);
            }
        }
        public virtual TimeSpan FULL_TIME {
            get {
                return (FINISH_CALC - TS_NEXTRUNTIME);
            }
        }
    }
}
