using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses
{
    public class DurationMap : ClassMap<Duration>
    {
        public DurationMap()
        {
            Id(x => x.DURATION_KEY);
            Map(x => x.DURATION_VALUE);
        }
    }
}
