using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetTransferByParamsMap : ClassMap<pGetTransferByParams> {
        public pGetTransferByParamsMap() {
            Id(x => x.TF_KEY);
            Map(x => x.TF_NAME);
            Map(x => x.TF_NAMELAT);
        }
    }
}
