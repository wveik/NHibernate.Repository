using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses
{
    public class pGetVisaTouristForSelect
    {
        public virtual int TU_KEY { get; set; }
        public virtual string TU_DGCOD { get; set; }
		public virtual string TU_NAMERUS { get; set; }
		public virtual string  TU_NAMELAT { get; set; }
		public virtual string  TU_FNAMERUS { get; set; }
		public virtual string  TU_FNAMELAT { get; set; }
		public virtual string  TU_SNAMERUS { get; set; }
		public virtual string  TU_SNAMELAT { get; set; }
		public virtual string  TU_BIRTHDAY { get; set; }
		public virtual int  DL_KEY { get; set; }
		public virtual string  DL_NAME { get; set; }
		public virtual double  DL_COST { get; set; }
		public virtual double  DL_BRUTTO { get; set; }
		public virtual string  DL_DATEBEG { get; set; }
		public virtual string  DL_DATEEND { get; set; }
		public virtual string  SL_NAME	 { get; set; }
    }
}
