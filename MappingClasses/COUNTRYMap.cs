using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class COUNTRYMap : ClassMap<COUNTRY> {
        public COUNTRYMap() {
            Id(x => x.CN_KEY);
            Map(x => x.CN_NAME);
            Map(x => x.CN_NAMELAT);
            Map(x => x.CN_FRAME);
            Map(x => x.CN_WEB);
            Map(x => x.CN_WEBIMAGE);
            Map(x => x.CN_WEBHTTP);
            Map(x => x.CN_CODE);
            Map(x => x.ROWID);
            Map(x => x.CN_AnkLang);
            Map(x => x.CN_StdKey);
            Map(x => x.CN_Updatedate);
            Map(x => x.CN_SMALLDESC);
            Map(x => x.CN_COKey);
            Map(x => x.CN_NameAC);
            Map(x => x.CN_CNTKey);
            Map(x => x.CN_PASPEXPMONTH);
            Map(x => x.CN_PASPEXPTYPE);
            Map(x => x.cn_dep_email);
            Map(x => x.cn_Accounting_type);
            Map(x => x.CN_VizaRelizTime);
            Map(x => x.CN_VoucherType);
        }
    }
}
