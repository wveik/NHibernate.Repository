using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses
{
    public class TourInfoMap : ClassMap<TourInfo>
    {
        public TourInfoMap()
        {
            Id(x => x.TOUR_TEMPLATE_KEY);
            Map(x => x.DIRECTION_NAME);            
            Map(x => x.START_CITY_NAME);
            Map(x => x.TOUR_FINISH_DATE);
            Map(x => x.TOUR_START_DATE);
            Map(x => x.TOUR_START_DATE_STRING);
            Map(x => x.TOUR_TEMPLATE_NAME);
            Map(x => x.TOUR_FINISH_DATE_STRING);
        }
    }
}
