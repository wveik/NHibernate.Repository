using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class GlobalPhoneForInvoiceMap : ClassMap<GlobalPhoneForInvoice> {
        public GlobalPhoneForInvoiceMap() {
            Id(x => x.GL_KEY);
            Map(x => x.GL_CTKEY);
            Map(x => x.GL_PHONE_NUMBER);
            Map(x => x.CT_NAME);
        }
    }
}
