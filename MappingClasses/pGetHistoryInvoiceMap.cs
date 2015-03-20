using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetHistoryInvoiceMap : ClassMap<pGetHistoryInvoice> {
        public pGetHistoryInvoiceMap() {
            Id(x => x.ID);
            Map(x => x.SUM);
            Map(x => x.COUNT_BOOKING);
            Map(x => x.STATUS);
            Map(x => x.STATUS_STRING);
            Map(x => x.INVOICEFILE);
            Map(x => x.ClinetMode);
            Map(x => x.DATE_CHANGE);
            Map(x => x.WHO);
            Map(x => x.MODE);
            Map(x => x.MODE_STRING);
            Map(x => x.KEY_HISTORY);

        }
    }
}
