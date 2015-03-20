using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses
{
    public class DiscountSessionPlacementItemMap : ClassMap<DiscountSessionPlacementItem>
    {
        public DiscountSessionPlacementItemMap()
        {
            Id(x => x.PLACEMENT_KEY);
            Map(x => x.PLACEMENT_1);
            Map(x => x.PLACEMENT_2);
            Map(x => x.PLACEMENT_3);
            Map(x => x.PLACEMENT_4);
            Map(x => x.PLACEMENT_5);
            Map(x => x.PLACEMENT_6);
            Map(x => x.PLACEMENT_7);
            Map(x => x.PLACEMENT_8);
            Map(x => x.PLACEMENT_9);
            Map(x => x.PLACEMENT_10);
            Map(x => x.PLACEMENT_11);
            Map(x => x.PLACEMENT_12);
            Map(x => x.PLACEMENT_13);
            Map(x => x.PLACEMENT_14);
            Map(x => x.PLACEMENT_15);
            Map(x => x.PLACEMENT_16);
            Map(x => x.PLACEMENT_17);
            Map(x => x.PLACEMENT_18);
            Map(x => x.PLACEMENT_19);
            Map(x => x.PLACEMENT_20);
            Map(x => x.PLACEMENT_21);
            Map(x => x.PLACEMENT_22);
            Map(x => x.PLACEMENT_23);
            Map(x => x.PLACEMENT_24);
            Map(x => x.PLACEMENT_25);
            Map(x => x.PLACEMENT_26);
            Map(x => x.PLACEMENT_27);
            Map(x => x.PLACEMENT_28);
            Map(x => x.PLACEMENT_29);
            Map(x => x.PLACEMENT_30);
        }
    }
}
