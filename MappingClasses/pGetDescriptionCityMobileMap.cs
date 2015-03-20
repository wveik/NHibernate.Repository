using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetDescriptionCityMobileMap : ClassMap<pGetDescriptionCityMobile> {
        public pGetDescriptionCityMobileMap() {
            Id(x => x.CT_KEY);
            Map(x => x.ct_dscr);
            Map(x => x.HD_DESCRIPT);
            Map(x => x.HOST);
            Map(x => x.AGENT);
        }
    }
}
