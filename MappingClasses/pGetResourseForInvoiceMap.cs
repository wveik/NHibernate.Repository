using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    
    public class pGetResourseForInvoiceMap : ClassMap<pGetResourseForInvoice> {
        public pGetResourseForInvoiceMap() {
            Id(x => x.ID_ResultTable);
            Map(x => x.DG_CODE);
            Map(x => x.DG_TURDATE);
            Map(x => x.Duration);
            Map(x => x.DG_CRDATE);
            Map(x => x.Tourists);
            Map(x => x.DL_NAME);
            Map(x => x.AnotherResourse);
            Map(x => x.Ann);
            Map(x => x.InInvoices);
            Map(x => x.Check_);
            Map(x => x.DL_KEY);
        }
    }
}
