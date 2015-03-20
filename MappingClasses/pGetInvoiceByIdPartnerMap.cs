using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetInvoiceByIdPartnerMap : ClassMap<pGetInvoiceByIdPartner> {
        public pGetInvoiceByIdPartnerMap() {
            Id(x => x.No);
            Map(x => x.Type);
            Map(x => x.CreationDate);
            Map(x => x.StartDate);
            Map(x => x.Creator);
            Map(x => x.Sum);
            Map(x => x.Rate);
            Map(x => x.Count);
            Map(x => x.Status);
            Map(x => x.Comment);
            Map(x => x.FileName);
            Map(x => x.StatusId);
        }
    }
}
