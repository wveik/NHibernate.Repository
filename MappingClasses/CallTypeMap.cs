using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class CallTypeMap : ClassMap<CallType> {
        public CallTypeMap() {
            Id(x => x.CT_KEY);
            Map(x => x.CT_TEXT);
        }
    }
}
