using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class IL_CITYMap : ClassMap<IL_CITY> {
        public IL_CITYMap() {
            Id(x => x.CT_KEY);
            Map(x => x.CT_ILKEY);
            Map(x => x.CT_NAME);
            Map(x => x.CT_CODE);
            Map(x => x.CT_MTKEY);
            Map(x => x.CT_CNKEY);
        }
    }
}
