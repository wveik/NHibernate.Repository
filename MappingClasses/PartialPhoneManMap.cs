using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class PartialPhoneManMap: ClassMap<PartialPhoneMan> {
        public PartialPhoneManMap() {
            Id(x => x.PM_KEY);
            Map(x => x.PM_USKEY);
            Map(x => x.PM_PHONE_NUMBER);
            Map(x => x.US_USERID);
            Map(x => x.US_SUBSIDIARY);
            Map(x => x.US_NAME);
            Map(x => x.GL_PHONE_NUMBER);
            Map(x => x.CT_NAME);
            Map(x => x.CT_KEY);
        }
    }
}
