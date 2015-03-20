using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses
{
    [Serializable]
    public class pGetVisaTourist
    {
        public virtual int VTT_KEY { get; set; }
        public virtual int VTT_LIST_KEY { get; set; }
        public virtual string VTT_RESERVATION_CODE { get; set; }
        public virtual int VTT_TOURIST_KEY { get; set; }
        public virtual int VTT_SERVICE_KEY { get; set; }
        public virtual int VTT_STATE { get; set; }
        public virtual string TU_NAMERUS { get; set; }
        public virtual string TU_FNAMERUS { get; set; }
        public virtual int DL_KEY { get; set; }
        public virtual string DL_NAME { get; set; }
        public virtual double DL_COST { get; set; }
        public virtual double DL_BRUTTO { get; set; }
        public virtual string DL_DATEBEG { get; set; }
        public virtual string DL_DATEEND { get; set; }
        public virtual string SL_NAME { get; set; }
    }
}
