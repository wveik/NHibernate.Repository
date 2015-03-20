using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetFullSumOfBookingInvoiceMap : ClassMap<pGetFullSumOfBookingInvoice> {
        public pGetFullSumOfBookingInvoiceMap() {
            Id(x => x.FSBI_KEY);
            Map(x => x.BI_KEY);
            Map(x => x.FSBI_BI_DOCKEY);
            Map(x => x.FSBI_BIS_SUMBYBILL);
            Map(x => x.FSBI_DG_CODE);
            Map(x => x.FSBI_BIS_SUMCOMM);
            Map(x => x.FSBI_BIS_CALL_BACK);
        }
    }
}
