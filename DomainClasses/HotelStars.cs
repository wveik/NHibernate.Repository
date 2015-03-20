using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses
{
    public class HotelStars
    {
        public virtual int WHS_KEY { get; set; }
        public virtual string WHS_STARS { get; set; }
    }
}
