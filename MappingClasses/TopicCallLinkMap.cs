using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class TopicCallLinkMap : ClassMap<TopicCallLink> {
        public TopicCallLinkMap() {
            Id(x => x.TCL_KEY);
            Map(x => x.TCL_TYPEKEY);
            Map(x => x.TCL_TCKEY);
            Map(x => x.TCL_HIDE);
        }
    }
}
