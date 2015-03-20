using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class ActionsMap : ClassMap<Actions> {
        public ActionsMap() {
            Id(x => x.AC_Key);
            Map(x => x.AC_Name);
            Map(x => x.AC_Description);
            Map(x => x.AC_CUSTOMSCRIPT);
        }
    }
}
