using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    class tfnGetOfficesForCallMap : ClassMap<tfnGetOfficesForCall> {
        public tfnGetOfficesForCallMap() {
            Id(x => x.OF_KEY);
            Map(x => x.OF_NAME);
            Map(x => x.OF_ADDRESS);
            Map(x => x.OF_PHONE);
            Map(x => x.Subway);
            Map(x => x.FirmName);
            Map(x => x.OF_CityPhone);
            Map(x => x.OF_TYPE);
            Map(x => x.OF_TYPENAME);
        }
    }
}
