using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses
{
    public class pVisaTouristListMap : ClassMap<pGetVisaTouristList>
    {
        public pVisaTouristListMap()
        {
            Id(x => x.VTL_KEY);
            Map(x => x.VTL_NAME);
            Map(x => x.VTL_COUNTRY_NAME);
            Map(x => x.VTL_PARTNER_NAME);
            Map(x => x.VTL_CURRENCY);
            Map(x => x.VTL_COST);
            Map(x => x.VTL_TOURIST_QUANTITY);
            Map(x => x.VTL_STATE);
            Map(x => x.VTL_FIRST_TOUR_START);
            Map(x => x.VTL_LAST_TOUR_START);
            Map(x => x.VTL_COMMENT);
            Map(x => x.VTL_PAYMENT_METHOD);
            Map(x => x.CREATION_DATE);
            Map(x => x.WHO_CREATED);
            Map(x => x.MODIFICATION_DATE);
            Map(x => x.WHO_MODIFIED);
        }
    }
}
