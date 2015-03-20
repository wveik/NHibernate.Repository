using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetHotDatesGroupMap : ClassMap<pGetHotDatesGroup> {
        public pGetHotDatesGroupMap() {
            Id(x => x.HDG_KEY);
            Map(x => x.HDG_NAME);
            Map(x => x.AUTOR_KEY);
            Map(x => x.AUTOR);
            Map(x => x.DESCRIPTION);
        }
    }
}
