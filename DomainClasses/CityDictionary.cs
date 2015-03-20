using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class CityDictionary {
        public virtual Int32 CT_CNKEY { get; set; }
        public virtual Int32 CT_KEY { get; set; }
        public virtual String CT_NAME { get; set; }
        public virtual String CT_NAMELAT { get; set; }
        public virtual String CT_CODE { get; set; }
        public virtual Int32 CT_CREATOR { get; set; }
        public virtual DateTime? CT_UPDATEDATE { get; set; }
        public virtual String ROWID { get; set; }
        public virtual Char? CT_StdKey { get; set; }
        public virtual Int32? CT_WEB { get; set; }
        public virtual String CT_WEBIMAGE { get; set; }
        public virtual Int32? CT_RSKEY { get; set; }
        public virtual String CT_NAMEAC { get; set; }
        public virtual Int32? ct_rgid { get; set; }
        public virtual String ct_dscr { get; set; }
        public virtual Int32? ct_timecorr { get; set; }
        public virtual short CT_IsFomCity { get; set; }

        public virtual Int32? CT_RG_KEY { get; set; }
        public virtual String RG_NAME { get; set; }
    }
}
