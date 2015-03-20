using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    class tfnGetOfficeTypesForCallMap : ClassMap<tfnGetOfficeTypesForCall> {
        public tfnGetOfficeTypesForCallMap() {
            Id(x => x.OF_TYPE);
            Map(x => x.OF_TYPENAME);
        }
    }
}
