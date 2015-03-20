using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class GlobalPhoneMap : ClassMap<GlobalPhone> {
        public GlobalPhoneMap() {
            Id(x => x.GL_KEY);
            Map(x => x.GL_CTKEY);
            Map(x => x.GL_PHONE_NUMBER);
        }
    }
}
