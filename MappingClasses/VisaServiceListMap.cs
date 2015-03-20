using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class VisaServiceListMap : ClassMap<VisaServiceList> {
        public VisaServiceListMap() {
            Id(x => x.VSL_KEY);
            Map(x => x.VSL_NAME);
            Map(x => x.VSL_CODE);
            Map(x => x.VSL_NAMELAT);
            Map(x => x.CN_NAME);
            Map(x => x.VSL_CNKEY);
            Map(x => x.VSL_IsSupportOnly);
            Map(x => x.VSL_AGEFROM);
            Map(x => x.VSL_AGETILL);
            Map(x => x.VSL_ADULT);
        }
    }
}
