using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    [Serializable]
    public class pGetTransferPrice {
        public virtual int TPFP_KEY { get; set; }
        public virtual int TPFP_FOR_HUMAN { get; set; }
        public virtual String CT_NAME { get; set; }
        public virtual String TYPE_PRICE { get; set; }
        public virtual String TPFP_DATE_FROM { get; set; }
        public virtual String TPFP_DATE_TILL { get; set; }
        public virtual Double TPFP_PRICE { get; set; }
        public virtual String TPFP_DATE_INSERT { get; set; }
        public virtual String TPFP_DATE_UPDATE { get; set; }
        public virtual int TF_KEY { get; set; }
        public virtual String TF_NAME { get; set; }
        public virtual String TF_NAMELAT { get; set; }
        public virtual int TR_KEY { get; set; }
        public virtual String TR_NAME { get; set; }
        public virtual String TR_NAMELAT { get; set; }
        
        public virtual Boolean Show { get; set; }
    }
}
