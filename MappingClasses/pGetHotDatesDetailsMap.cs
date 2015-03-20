using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetHotDatesDetailsMap : ClassMap<pGetHotDatesDetails> {
        public pGetHotDatesDetailsMap() {
            Id(x => x.HDGD_KEY);
            Map(x => x.NAME);
            Map(x => x.HDGD_CITY_FROM);
            Map(x => x.HDGD_CITY_TILL);
            Map(x => x.HDGD_HDG_KEY);
            Map(x => x.HDGD_ORDER);
        }
    }
}
