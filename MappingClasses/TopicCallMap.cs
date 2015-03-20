using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class TopicCallMap : ClassMap<TopicCall> {
        public TopicCallMap() {
            Id(x => x.TC_KEY);
            Map(x => x.TC_TEXT);
            Map(x => x.TC_COMMENT);
            Map(x => x.TC_TYPE_INN);
            Map(x => x.TC_TYPE_OUT);
            Map(x => x.TC_HIDE);
            Map(x => x.TC_DATE);
            Map(x => x.TC_OWNER);
            Map(x => x.TC_WHO);
        }
    }
}
