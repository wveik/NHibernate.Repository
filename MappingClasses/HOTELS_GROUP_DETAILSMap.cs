using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class HOTELS_GROUP_DETAILSMap : ClassMap<HOTELS_GROUP_DETAILS> {
        public HOTELS_GROUP_DETAILSMap() {
            Id(x => x.HGD_KEY);
            Map(x => x.HGD_HGKEY);
            Map(x => x.HGD_HDKEY);
        }
    }
}
