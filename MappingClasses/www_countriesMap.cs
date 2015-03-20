using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class www_countriesMap : ClassMap<www_countries_short> {
        public www_countriesMap() {
            Id(x => x.cn_id);
            Map(x => x.cn_name);
        }
    }
}
