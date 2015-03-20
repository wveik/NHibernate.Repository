using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class PARTNERS {
        public virtual Int32 PR_KEY { get; set; }
        public virtual String PR_FULLNAME { get; set; }
        public virtual String PR_NAME { get; set; }
        public virtual String PR_NAMEENG { get; set; }
        public virtual String PR_BOSSNAME { get; set; }
        public virtual String PR_BOSS { get; set; }
        public virtual short? PR_MALE { get; set; }
        public virtual String PR_MAINMEN { get; set; }
        public virtual String PR_MAINMENPHONE { get; set; }
        public virtual String PR_DISCOUNT { get; set; }
        public virtual String PR_ACCOUNT { get; set; }
        public virtual String PR_ADRESS { get; set; }
        public virtual String PR_PHONES { get; set; }
        public virtual String PR_FAX { get; set; }
        public virtual String PR_EMAIL { get; set; }
        public virtual Int32? PR_CTKEY { get; set; }
        public virtual Int32 PR_CREATOR { get; set; }
        public virtual String PR_AGENTDOGOVOR { get; set; }
        public virtual Int32? PR_TYPE { get; set; }
        public virtual String PR_CITY { get; set; }
        public virtual Int32? PR_WEBAGENT { get; set; }
        public virtual DateTime? PR_AGENTDATE { get; set; }
        public virtual String PR_AGENTDOGOVOR2 { get; set; }
        public virtual DateTime? PR_AGENTDATE2 { get; set; }
        public virtual String PR_FAX1 { get; set; }
        public virtual String PR_REMARK { get; set; }
        public virtual DateTime? PR_CREATEDATE { get; set; }
        public virtual DateTime? PR_UPDATEDATE { get; set; }
        public virtual Int32? PR_ART { get; set; }
        public virtual Int32? PR_USERLAST { get; set; }
        public virtual String PR_COD { get; set; }
        public virtual String ROWID { get; set; }
        public virtual Char? LastUser { get; set; }
        public virtual DateTime? LastUpdate { get; set; }
        public virtual Int32 pr_IsActive { get; set; }
        public virtual Int32 PR_Filial { get; set; }
        public virtual DateTime? PR_DateLastContact { get; set; }
        public virtual String PR_ExchangePwd { get; set; }
        public virtual String PR_GUID { get; set; }
        public virtual String PR_ExchangeData { get; set; }
        public virtual String MaskedFax { get; set; }
        public virtual String PR_IPADDRESS { get; set; }
        public virtual short PR_DogovorType { get; set; }
        public virtual String PR_ICQ { get; set; }
        public virtual String PR_Gds_Prefix { get; set; }
        public virtual String PR_Gds_Suffix { get; set; }
        public virtual Int32? PR_Owner { get; set; }
        public virtual Int32? PR_SEND2IL { get; set; }
        public virtual String PR_ADDINFO { get; set; }
        public virtual short? PR_Priority { get; set; }
        public virtual short? PR_AviaKassa { get; set; }
        public virtual String PR_COMMONNAME { get; set; }
        public virtual String pr_outname { get; set; }
        public virtual Int32 pr_order { get; set; }
        public virtual String pr_reestrnum { get; set; }
        public virtual String pr_garantee_doc { get; set; }
        public virtual String pr_garantee_amount { get; set; }
        public virtual String pr_garantee_holder { get; set; }
        public virtual String pr_garantee_holderaddress { get; set; }
        public virtual String pr_postaddress { get; set; }
        public virtual Int32? pr_parent { get; set; }
        public virtual short pr_root { get; set; }
        public virtual Int32 PR_FR_ENTKEY { get; set; }
        public virtual String PR_PENALTIES { get; set; }
        public virtual Int32? PR_OFFICE { get; set; }
        public virtual DateTime? pr_garantee_datetill { get; set; }
        public virtual Int32 PR_ENTKEY { get; set; }
        public virtual short PR_IsAgentNet { get; set; }
        public virtual Int32? pr_franchtype { get; set; }
        public virtual String PR_INN { get; set; }
        public virtual String PR_KPP { get; set; }
        public virtual String PR_OKPO { get; set; }
        public virtual String PR_OKATO { get; set; }
        public virtual String PR_BankName { get; set; }
        public virtual String PR_BankRS { get; set; }
        public virtual String PR_BankKS { get; set; }
        public virtual String PR_BankBIK { get; set; }
        public virtual String PR_EMail_Account { get; set; }
        public virtual Int32 PR_RootOffice { get; set; }
        public virtual String PR_COUNTRY { get; set; }
        public virtual Int32? PR_CNKEY { get; set; }
        public virtual Int32? PR_OWNERSHIPKEY { get; set; }
        public virtual short pr_IsParentDog { get; set; }
        public virtual short pr_IsParentViewResrvs { get; set; }
        public virtual short pr_IsParentBalance { get; set; }
        public virtual short pr_IsParentAnotherLegal { get; set; }
        public virtual Int32? PR_SHARED_CONTRACT { get; set; }
    }
}
