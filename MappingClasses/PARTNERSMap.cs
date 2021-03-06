﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class PARTNERSMap : ClassMap<PARTNERS> {
        public PARTNERSMap() {
            Id(x => x.PR_KEY);
            Map(x => x.PR_FULLNAME);
            Map(x => x.PR_NAME);
            Map(x => x.PR_NAMEENG);
            Map(x => x.PR_BOSSNAME);
            Map(x => x.PR_BOSS);
            Map(x => x.PR_MALE);
            Map(x => x.PR_MAINMEN);
            Map(x => x.PR_MAINMENPHONE);
            Map(x => x.PR_DISCOUNT);
            Map(x => x.PR_ACCOUNT);
            Map(x => x.PR_ADRESS);
            Map(x => x.PR_PHONES);
            Map(x => x.PR_FAX);
            Map(x => x.PR_EMAIL);
            Map(x => x.PR_CTKEY);
            Map(x => x.PR_CREATOR);
            Map(x => x.PR_AGENTDOGOVOR);
            Map(x => x.PR_TYPE);
            Map(x => x.PR_CITY);
            Map(x => x.PR_WEBAGENT);
            Map(x => x.PR_AGENTDATE);
            Map(x => x.PR_AGENTDOGOVOR2);
            Map(x => x.PR_AGENTDATE2);
            Map(x => x.PR_FAX1);
            Map(x => x.PR_REMARK);
            Map(x => x.PR_CREATEDATE);
            Map(x => x.PR_UPDATEDATE);
            Map(x => x.PR_ART);
            Map(x => x.PR_USERLAST);
            Map(x => x.PR_COD);
            Map(x => x.ROWID);
            Map(x => x.LastUser);
            Map(x => x.LastUpdate);
            Map(x => x.pr_IsActive);
            Map(x => x.PR_Filial);
            Map(x => x.PR_DateLastContact);
            Map(x => x.PR_ExchangePwd);
            Map(x => x.PR_GUID);
            Map(x => x.PR_ExchangeData);
            Map(x => x.MaskedFax);
            Map(x => x.PR_IPADDRESS);
            Map(x => x.PR_DogovorType);
            Map(x => x.PR_ICQ);
            Map(x => x.PR_Gds_Prefix);
            Map(x => x.PR_Gds_Suffix);
            Map(x => x.PR_Owner);
            Map(x => x.PR_SEND2IL);
            Map(x => x.PR_ADDINFO);
            Map(x => x.PR_Priority);
            Map(x => x.PR_AviaKassa);
            Map(x => x.PR_COMMONNAME);
            Map(x => x.pr_outname);
            Map(x => x.pr_order);
            Map(x => x.pr_reestrnum);
            Map(x => x.pr_garantee_doc);
            Map(x => x.pr_garantee_amount);
            Map(x => x.pr_garantee_holder);
            Map(x => x.pr_garantee_holderaddress);
            Map(x => x.pr_postaddress);
            Map(x => x.pr_parent);
            Map(x => x.pr_root);
            Map(x => x.PR_FR_ENTKEY);
            Map(x => x.PR_PENALTIES);
            Map(x => x.PR_OFFICE);
            Map(x => x.pr_garantee_datetill);
            Map(x => x.PR_ENTKEY);
            Map(x => x.PR_IsAgentNet);
            Map(x => x.pr_franchtype);
            Map(x => x.PR_INN);
            Map(x => x.PR_KPP);
            Map(x => x.PR_OKPO);
            Map(x => x.PR_OKATO);
            Map(x => x.PR_BankName);
            Map(x => x.PR_BankRS);
            Map(x => x.PR_BankKS);
            Map(x => x.PR_BankBIK);
            Map(x => x.PR_EMail_Account);
            Map(x => x.PR_RootOffice);
            Map(x => x.PR_COUNTRY);
            Map(x => x.PR_CNKEY);
            Map(x => x.PR_OWNERSHIPKEY);
            Map(x => x.pr_IsParentDog);
            Map(x => x.pr_IsParentViewResrvs);
            Map(x => x.pr_IsParentBalance);
            Map(x => x.pr_IsParentAnotherLegal);
            Map(x => x.PR_SHARED_CONTRACT);
        }
    }
}
