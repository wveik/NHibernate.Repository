using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using NHibernate;
using System.Runtime.CompilerServices;

namespace RIVIERA.NHibernate.Repository.PreparedQuery {
    public static class PreparedQuery {
        public const string COMMERCIAL_DICTIONARIES = "COMMERCIAL_DICTIONARIES";

        /// <summary>
        /// Получить города вылетов из которых мы летаем в коллекции KEY/VALUE
        /// </summary>
        /// <param name="session"></param>
        /// <returns></returns>
        public static IList<SimpleKeyValue> GetCityFlightFrom(this ISession session) {
            return session.CreateSQLQuery(@"
                    SELECT 
                        -1 AS 'KEY',
                        '<Все города>' AS NAME 
                    
                    UNION
    
                        SELECT 
                        CT_KEY AS 'KEY',
                        CT_NAME AS NAME
                        FROM CityDictionary
                        WHERE
                        ISNULL(CT_IsFomCity, 0)=1
                        ORDER BY NAME
                                        ")
                        .AddEntity(typeof(SimpleKeyValue))
                        .List<SimpleKeyValue>();
        }

        public static IList<PARTNERS> GetAgentList(this ISession session) {
            return session.CreateSQLQuery(@"
                        SELECT *
                        FROM Partners 
                        WHERE PR_KEY > 1 AND ISNULL(PR_TYPE,0)&4 = 4 and PR_FULLNAME IS NOT NULL AND PR_FULLNAME <> '' 
                        ORDER BY PR_NAME
                                        ")
                        .AddEntity(typeof(PARTNERS))
                        .List<PARTNERS>();
        }
        public static IList<FIN_OFFICES> GetFinOfficeList(this ISession session) {
            return session.CreateSQLQuery(@"
                                select 
                                OF_KEY,OF_FRKEY,OF_DESCRIPTION,OF_NAME,OF_ISFOLDER,OF_PARENT,OF_DSKEY,OF_CTKEY,OF_MAIN,OF_ADDRESS,OF_HotCenter,OF_ISFRANCH,OF_PHONE,OF_CODE,OF_SYSDATA,OF_ENTKEY,OF_ROOTOFFICE,OF_RootMainOffice,DS_KEY,DS_DELETED 
                                ,dbo.GetFINOfficeMetroStation(of_key) as Subway
                                from fin_offices
                                join fin_dictionaries on ds_key = of_dskey
                                where ds_deleted=0
                                and of_isfolder=0
                                and of_frkey = 37951
                                ORDER BY OF_NAME

                                        ")
                        .AddEntity(typeof(FIN_OFFICES))
                        .List<FIN_OFFICES>();
        }
        public static PhoneMan GetPhoneMan(this ISession session) {
            return session.CreateSQLQuery(@"
                            SELECT * FROM dbo.PhoneMan
                            WHERE PM_USKEY=dbo.fnGetUserKey(USER)")
                                            .AddEntity(typeof(PhoneMan))
                                            .List<PhoneMan>().FirstOrDefault();
        }
        public static IList<PartialPhoneMan> GetPartialPhoneMan(this ISession session, WithAllOrNotPartialPhoneMan _enum) {
            String with = _enum == WithAllOrNotPartialPhoneMan.WithAll ? @"                    SELECT -1 AS PM_KEY, -1 AS PM_USKEY, '<Все телефоны>' AS PM_PHONE_NUMBER, '<Все работники>' AS US_USERID, '<Все работники>' AS US_SUBSIDIARY, '<Все работники>' AS US_NAME, '<Все работники>' AS GL_PHONE_NUMBER, '<Все города>' AS CT_NAME, -1 as CT_KEY
                    UNION ALL" : "";
            return session.CreateSQLQuery(with + @"
                    SELECT PM_KEY, PM_USKEY, PM_PHONE_NUMBER, US_USERID, US_SUBSIDIARY, US_NAME, GL_PHONE_NUMBER, CT_NAME, CT_KEY FROM PhoneMan p
                                    INNER JOIN UserList u on p.PM_USKEY = US_KEY
                                    INNER JOIN GlobalPhone g ON g.GL_KEY = PM_GLKEY
                                    INNER JOIN CityDictionary ct ON g.GL_CTKEY = ct.CT_KEY
                                    WHERE PM_GLKEY = (
	                                    SELECT TOP 1 PM_GLKEY FROM PhoneMan PM WHERE PM.PM_USKEY = dbo.fnGetUserKey(USER_NAME())
                                    )")
                                            .AddEntity(typeof(PartialPhoneMan))
                                            .List<PartialPhoneMan>();
        }
        public static IList<TopicCall> GetTopicList(this ISession session) {
            return session.CreateSQLQuery(@"
                                            SELECT * FROM TopicCall
                                            WHERE TC_HIDE=0")
                                                .AddEntity(typeof(TopicCall))
                                                .List<TopicCall>();
        }
        public static IList<PARTNERS> GetPartnersThatGivePricesByKey(this ISession session, Int32 US_KEY) {
            return session.CreateSQLQuery(@"                                            
                                            SELECT * from Partners 
                                            WHERE isnull(pr_type,0)&8=8 
                                            AND PR_KEY=
                                            (
                                                SELECT US_PRKEY FROM dup_user
                                                WHERE US_KEY=:US_KEY
                                            )
                                            ORDER BY PR_NAME")
                                                .AddEntity(typeof(PARTNERS))
                                                .SetParameter("US_KEY", US_KEY)
                                                .List<PARTNERS>();
        }

        public static IList<PARTNERS> GetPartnersThatGivePricesByOwnUser(this ISession session, Int32 CNP_USKEY) {
            return session.CreateSQLQuery(@"                                            
                                            SELECT * from Partners 
                                            WHERE isnull(pr_type,0)&8=8 
                                            AND PR_KEY
                                            IN (
                                                    SELECT CNP_PRKEY FROM Confiramtor_PartnerAccess
                                                    WHERE CNP_USKEY=:CNP_USKEY
                                                )
                                            ORDER BY PR_NAME")
                                                .AddEntity(typeof(PARTNERS))
                                                .SetParameter("CNP_USKEY", CNP_USKEY)
                                                .List<PARTNERS>();
        }

        public static IList<string> GetRateInvoiceSelectedPartner(this ISession session, Int32 PARTNERKEY) {
            var temp = session.CreateSQLQuery(@"                                            
                                            SELECT DISTINCT DG_RATE FROM DOGOVOR
                                            INNER JOIN DOGOVORLIST on DG_CODE=DL_DGCOD
                                            WHERE
                                            DG_TURDATE>=DATEADD(MONTH, -2, GETDATE())
                                            AND
                                            DL_PARTNERKEY=:PARTNERKEY
                                            ORDER BY DG_RATE")
                                                .SetParameter("PARTNERKEY", PARTNERKEY)
                                                .List();
            List<string> result = new List<string>(temp.Count);
            foreach (var item in temp) {
                result.Add((string)item);
            }
            return result;
        }

        public static IList<CityDictionary> GetCitiesByCountryKey(this ISession session, Int32 keyCountry) {
            IList<CityDictionary> result;
            result = session.CreateSQLQuery(@"
                                        SELECT
                                        CT_CNKEY,CT_KEY,CT_NAME,CT_NAMELAT,CT_CODE,CT_CREATOR,CT_UPDATEDATE,ROWID,CT_StdKey,CT_WEB,CT_WEBIMAGE,CT_RSKEY,CT_NAMEAC,ct_rgid, null as ct_dscr,ct_timecorr,CT_IsFomCity,CT_RG_KEY
,RG_NAME                                        
FROM CityDictionary
LEFT JOIN REGION ON CT_RG_KEY=RG_KEY
                                        WHERE
                                        :key=CT_CNKEY 
                                        ORDER BY CT_NAME
                                        ")
                    .AddEntity(typeof(CityDictionary))
                    .SetParameter<int>("key", keyCountry)
                    .List<CityDictionary>();

            return result;
        }

        public static bool IsUpdateTable(this ISession session, String nameTable) {
            int result = (int)session.CreateSQLQuery(
                string.Format(@"
if exists(select 1 from dbo.sysobjects WHERE id = object_id(N'{0}') and OBJECTPROPERTY(id, N'IsView') = 1) 
 and exists(select 1 from dbo.sysobjects WHERE id = object_id(N'tbl_{0}') and OBJECTPROPERTY(id, N'IsView') = 0)
                SELECT PERMISSIONS (OBJECT_ID ('tbl_{0}')) & 2  
                    else 
                SELECT PERMISSIONS (OBJECT_ID ('{0}')) & 2  
            ", nameTable))
             .List<Object>()[0];

            if ((result & 2) == 2)
                return true;

            return false;
        }

        private static HashSet<string> _cd_view_created = new HashSet<string>();

        [MethodImpl(MethodImplOptions.Synchronized)]
        private static void CreateRequiredView(ISession session)
        {
            if (_cd_view_created.Contains(session.Connection.ConnectionString))
                return;

            session.CreateSQLQuery(@"IF NOT EXISTS (SELECT VI_KEY FROM [View] WHERE VI_NAME = 'COMMERCIAL_DICTIONARIES')
                INSERT INTO [View] (VI_NAME, VI_TYPE) VALUES ( 'COMMERCIAL_DICTIONARIES',  0)").ExecuteUpdate();

            _cd_view_created.Add(session.Connection.ConnectionString);
        }

        public static HashSet<int> GetCommercialPermissions(this ISession session)
        {
            CreateRequiredView(session);

            return new HashSet<int>(session.CreateSQLQuery(@"SELECT VIC_KEYVALUE FROM ViewContents
INNER JOIN [View] ON VI_KEY = VIC_VIKEY
WHERE VI_NAME = 'COMMERCIAL_DICTIONARIES' AND VIC_USKEY = dbo.fnGetUserKey(USER_NAME())").List<int>());
        }
    }

    public enum WithAllOrNotPartialPhoneMan { 
        WithAll,
        NotAll
    }
}
