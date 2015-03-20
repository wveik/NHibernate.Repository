using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses
{
    public class DiscountSessionItem
    {
        public virtual int DSD_KEY { get; set; }
        public virtual int DSD_ACKEY { get; set; }
        public virtual string DSD_ACNAME { get; set; }
        public virtual int DSD_PERSON_IN_GROUP { get; set; }
        public virtual int DSD_ADULT_PERSON_IN_GROUP { get; set; }
        public virtual int DSD_SESSION_KEY { get; set; }
        public virtual DateTime DSD_TURDATE { get; set; }
        public virtual string DSD_TURDATE_STRING { get; set; }
        public virtual int DSD_NDAYS { get; set; }
        public virtual string DSD_TOURNAME { get; set; }
        public virtual int DSD_HOTEL_KEY { get; set; }
        public virtual string DSD_HOTEL_NAME { get; set; }
        public virtual int DSD_PNKEY { get; set; }
        public virtual string DSD_PNNAME { get; set; }        
        public virtual int DSD_TOUR_TEMPLATE_KEY { get; set; }
        public virtual long DSD_BOOK_KEY { get; set; }
        public virtual decimal DSD_PRICE { get; set; }
        public virtual decimal DSD_CALCLULATED_PRICE { get; set; }
        public virtual decimal? DSD_DISCOUNT { get; set; }
        public virtual int DSD_ROOM_CATEGORY_KEY { get; set; }
        public virtual string DSD_ROOM_CATEGORY_NAME { get; set; }
        public virtual decimal? DSD_NEW_DISCOUNT { get; set; }
        public virtual decimal? DSD_NEW_PRICE { get; set; }
        public virtual decimal? DSD_SELLING_PRICE { get; set; }
        public virtual decimal? DSD_NETTO { get; set; }
        public virtual decimal? DSD_MARGIN { get; set; }
        public virtual decimal? DSD_ADDITIONAL_SERVICES_COST { get; set; }

        public virtual short? DSD_APPLY_TO_ALL { get; set;}
        public virtual short? DSD_MARGIN_TYPE { get; set;}
		public virtual decimal? DSD_DISCOUNT_PRICE_VALUE { get; set;}
		public virtual short? DSD_SCOPE { get; set;}

        public virtual bool? DSD_IS_SELECTED { get; set; }
        public virtual bool? DSD_IS_MODEL { get; set; }
        public virtual int TOUR_TEMPLATE_KEY { get; set; }
    }
}
