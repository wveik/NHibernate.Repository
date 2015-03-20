using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class fGetRangeWidthMap : ClassMap<fGetRangeWidth> {
        public fGetRangeWidthMap() {
            Id(x => x.ID);
            Map(x => x.COUNT_FROM);
            Map(x => x.COUNT_TILL);
        }
    }
}
