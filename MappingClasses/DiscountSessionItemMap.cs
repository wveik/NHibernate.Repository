using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses
{
    public class DiscountSessionItemMap : ClassMap<DiscountSessionItem>
    {
        public DiscountSessionItemMap()
        {
            Id(x => x.DSD_KEY);
            Map(x => x.DSD_ACKEY);
            Map(x => x.DSD_ACNAME);
            Map(x => x.DSD_PERSON_IN_GROUP);
            Map(x => x.DSD_ADULT_PERSON_IN_GROUP);
            Map(x => x.DSD_ADDITIONAL_SERVICES_COST);
            Map(x => x.DSD_BOOK_KEY);
            Map(x => x.DSD_CALCLULATED_PRICE);
            Map(x => x.DSD_DISCOUNT);
            Map(x => x.DSD_HOTEL_KEY);
            Map(x => x.DSD_HOTEL_NAME);
            Map(x => x.DSD_IS_MODEL);
            Map(x => x.DSD_IS_SELECTED);
            //Map(x => x.DSD_MARGIN);
            Map(x => x.DSD_NDAYS);
            Map(x => x.DSD_NETTO);
            Map(x => x.DSD_NEW_DISCOUNT);
            Map(x => x.DSD_NEW_PRICE);
            Map(x => x.DSD_PNKEY);
            Map(x => x.DSD_PNNAME);
            Map(x => x.DSD_PRICE);
            Map(x => x.DSD_ROOM_CATEGORY_KEY);
            Map(x => x.DSD_ROOM_CATEGORY_NAME);
            //Map(x => x.DSD_SELLING_PRICE);
            Map(x => x.DSD_SESSION_KEY);
            Map(x => x.DSD_TOUR_TEMPLATE_KEY);
            Map(x => x.DSD_TOURNAME);
            Map(x => x.DSD_TURDATE);
            Map(x => x.DSD_TURDATE_STRING);
            Map(x => x.TOUR_TEMPLATE_KEY);

            Map(x => x.DSD_APPLY_TO_ALL);
            Map(x => x.DSD_MARGIN_TYPE);
            Map(x => x.DSD_DISCOUNT_PRICE_VALUE);
            Map(x => x.DSD_SCOPE);
        }
    }
}
