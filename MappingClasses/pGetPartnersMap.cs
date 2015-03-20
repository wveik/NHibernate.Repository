using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses
{
    public class pGetPartnersMap : ClassMap<pGetPartners>
    {
        public pGetPartnersMap()
        {
            Id(x => x.PR_KEY);
            Map(x => x.PR_FULLNAME);
            Map(x => x.PR_NAME);
        }
    }
}
