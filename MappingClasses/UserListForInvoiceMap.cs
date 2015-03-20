using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class UserListForInvoiceMap : ClassMap<UserListForInvoice> {
        public UserListForInvoiceMap() {
            Id(x => x.US_KEY);
            Map(x => x.US_USERID);
            Map(x => x.US_JOB);
            Map(x => x.US_SUBSIDIARY);
            Map(x => x.US_FNAME);
            Map(x => x.US_NAME);
        }
    }
}
