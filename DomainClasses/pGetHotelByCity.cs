using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    [Serializable]
    public class pGetHotelByCity {
        public virtual int HD_CNKEY { get; set; }
        public virtual int HD_CTKEY { get; set; }
        public virtual int HD_KEY { get; set; }
        public virtual String HD_NAME { get; set; }
    }
}
