using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses
{
    public class HotelStarsMap : ClassMap<HotelStars>
    {
        public HotelStarsMap()
        {
            Id(x => x.WHS_KEY);
            Map(x => x.WHS_STARS);
        }
    }
}
