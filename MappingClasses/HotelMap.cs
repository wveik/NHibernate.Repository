using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses
{
    public class HotelMap : ClassMap<Hotel>
    {
        public HotelMap()
        {
            Id(x => x.HD_KEY);
            Map(x => x.HD_NAME);
        }
    }
}
