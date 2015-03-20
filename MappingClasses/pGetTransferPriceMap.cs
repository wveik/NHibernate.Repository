using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetTransferPriceMap : ClassMap<pGetTransferPrice> {
        public pGetTransferPriceMap() {
            Id(x => x.TPFP_KEY);
            Map(x => x.TPFP_FOR_HUMAN); 
            Map(x => x.TYPE_PRICE); 
            Map(x => x.TPFP_DATE_FROM);
            Map(x => x.TPFP_DATE_TILL); 
            Map(x => x.TPFP_PRICE); 
            Map(x => x.TPFP_DATE_INSERT); 
            Map(x => x.TPFP_DATE_UPDATE); 
            Map(x => x.TF_KEY); 
            Map(x => x.TF_NAME); 
            Map(x => x.TF_NAMELAT);
            Map(x => x.TR_KEY); 
            Map(x => x.TR_NAME); 
            Map(x => x.TR_NAMELAT);
        }
    }
}
