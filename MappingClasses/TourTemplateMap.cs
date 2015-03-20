using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses
{
    public class TourTemplateMap : ClassMap<TourTemplate>
    {
        public TourTemplateMap()
        {
            Id(x => x.TL_KEY);
            Map(x => x.TL_NAME);
        }
    }
}
