using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetHotelsGroupMap : ClassMap<pGetHotelsGroup> {
        public pGetHotelsGroupMap() {
            Id(x => x.HG_KEY);
            Map(x => x.CN_NAME);
            Map(x => x.HG_CNKEY);
            Map(x => x.HG_CREATE_DATE); 
            Map(x => x.HG_HIDE);
            Map(x => x.HG_LAST_UPDATE);
            Map(x => x.HG_NAME);
        }
    }
}
