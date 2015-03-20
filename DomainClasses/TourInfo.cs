using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses
{
    public class TourInfo
    {
        public virtual int TOUR_TEMPLATE_KEY { get; set; }
        public virtual string TOUR_TEMPLATE_NAME { get; set; }
        public virtual string DIRECTION_NAME { get; set; }
        public virtual string START_CITY_NAME { get; set; }        
        public virtual DateTime TOUR_START_DATE { get; set; }
        public virtual string TOUR_START_DATE_STRING { get; set; }
        public virtual DateTime TOUR_FINISH_DATE { get; set; }
        public virtual string TOUR_FINISH_DATE_STRING { get; set; }
    }
}
