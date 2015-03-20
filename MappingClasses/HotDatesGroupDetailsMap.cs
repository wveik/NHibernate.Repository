using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class HotDatesGroupDetailsMap : ClassMap<HotDatesGroupDetails> {
        public HotDatesGroupDetailsMap() {
            Id(x => x.HDGD_KEY);
            Map(x => x.HDGD_CITY_FROM);
            Map(x => x.HDGD_CITY_TILL);
            Map(x => x.HDGD_HDG_KEY);
            Map(x => x.HDGD_ORDER);
        }
    }
}
