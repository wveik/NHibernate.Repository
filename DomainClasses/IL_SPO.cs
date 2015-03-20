using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class IL_SPO {
        public virtual int SPT_ID { get; set; }
        public virtual int SPT_KEY { get; set; }
        public virtual int SPT_SVKEY { get; set; }
        public virtual int? SPT_DURATION_MIN { get; set; }
        public virtual int? SPT_DURATION_MAX { get; set; }
        public virtual string SPT_SPONUMBER { get; set; }
        public virtual string SPT_COMMENT { get; set; }
        public virtual int SPT_SPOTYPE { get; set; }
        public virtual int? SPT_SPOSTATE { get; set; }
        public virtual int? SPT_TARIFKEY { get; set; }
        public virtual DateTime SPT_CREATEDATE { get; set; }
        public virtual DateTime? SPT_BOOKINGDATE_FROM { get; set; }
        public virtual DateTime? SPT_BOOKINGDATE_TO { get; set; }
        public virtual int? SPT_COUNTCOSTS { get; set; }
        public virtual int? SPT_MTSPOKEY { get; set; }
        public virtual int SPT_ILKEY { get; set; }
        public virtual DateTime? SPT_PARTNER_CREATEDATE { get; set; }
    }
}
