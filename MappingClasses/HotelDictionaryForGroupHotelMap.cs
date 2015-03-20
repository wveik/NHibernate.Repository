using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class HotelDictionaryForGroupHotelMap : ClassMap<HotelDictionaryForGroupHotel> {
        public HotelDictionaryForGroupHotelMap() {
            Id(x => x.HD_KEY);
            Map(x => x.HD_CNKEY);
            Map(x => x.HD_CTKEY);
            Map(x => x.CT_NAME);
            Map(x => x.HD_NAME);
            Map(x => x.HD_STARS);
        }
    }
}
