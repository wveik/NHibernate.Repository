using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetInvoiceDetailsMap : ClassMap<pGetInvoiceDetails> {
        public pGetInvoiceDetailsMap() {
            Id(x => x.DL_KEY);
            Map(x => x.BIS_DLKEY);
            Map(x => x.BIS_BIKEY);
            Map(x => x.DG_CODE);
            Map(x => x.DL_NAME);
            Map(x => x.DL_COST);
            Map(x => x.BIS_SUMBYBILL);
            Map(x => x.BIS_SUMCOMM);
            Map(x => x.BIS_CALL_BACK);
            Map(x => x.CANCEL);
            Map(x => x.FN_BIS_SUMBYBILL);
        }
    }
}
