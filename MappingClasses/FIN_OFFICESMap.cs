using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class FIN_OFFICESMap : ClassMap<FIN_OFFICES> {
        public FIN_OFFICESMap() {
            Id(x => x.OF_KEY);
            Map(x => x.OF_FRKEY);
            Map(x => x.OF_DESCRIPTION);
            Map(x => x.OF_NAME);
            Map(x => x.OF_ISFOLDER);
            Map(x => x.OF_PARENT);
            Map(x => x.OF_DSKEY);
            Map(x => x.OF_CTKEY);
            Map(x => x.OF_MAIN);
            Map(x => x.OF_ADDRESS);
            Map(x => x.OF_HotCenter);
            Map(x => x.OF_ISFRANCH);
            Map(x => x.OF_PHONE);
            Map(x => x.OF_CODE);
            Map(x => x.OF_SYSDATA);
            Map(x => x.OF_ENTKEY);
            Map(x => x.OF_ROOTOFFICE);
            Map(x => x.OF_RootMainOffice);
            Map(x => x.Subway);
        }
    }
}
