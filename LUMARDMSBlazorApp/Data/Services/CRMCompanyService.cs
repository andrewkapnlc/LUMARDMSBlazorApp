using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LUMARDMSBlazorApp.Data
{
    public class CRMCompanyService : ICRMCompanyService
    {
        private readonly List<CRMCompany> cRMCompany = new List<CRMCompany>
        {
            new CRMCompany
            {
                Comp_CompanyId = new int(),
		        Comp_PrimaryPersonId = 100,
		        Comp_PrimaryAddressId = 100,
		        Comp_Name = "Rio Tinto",
		        Comp_Type = "Company",
		        Comp_Status = "Active",
		        Comp_PrimaryAccountId = 100,
                Comp_RoyCustId = "AA12356",
                Comp_FinCustId = "CUST",
                Comp_StirkeCustId = "ab00c",
                comp_business_type = "Australian Company",
                comp_abn = "12563478",
                comp_acn = "A1245633",
                comp_icn = "",
                //todo add business entity model
                comp_BusinessName = "abc",
                comp_AnzsicCodes = "abc",
                //todo - add Royalty Company Model               
	        },
               new CRMCompany
            {
                Comp_CompanyId = new int(),
                Comp_PrimaryPersonId = 100,
                Comp_PrimaryAddressId = 100,
                Comp_Name = "Rio Tinto",
                Comp_Type = "Company",
                Comp_Status = "Active",
                Comp_PrimaryAccountId = 100,
                Comp_RoyCustId = "AA12356",
                Comp_FinCustId = "CUST",
                Comp_StirkeCustId = "ab00c",
                   comp_business_type = "Australian Company",
                comp_abn = "12563478",
                comp_acn = "A1245633",
                comp_icn = "",
                //todo add business entity model
                comp_BusinessName = "abc",
                comp_AnzsicCodes = "abc",
                //todo - add Royalty Company Model
            },
                  new CRMCompany
            {
                Comp_CompanyId = new int(),
                Comp_PrimaryPersonId = 100,
                Comp_PrimaryAddressId = 100,
                Comp_Name = "Telstra Health",
                Comp_Type = "Company",
                Comp_Status = "Active",
                Comp_PrimaryAccountId = 100,
               Comp_RoyCustId = "AA12356",
                Comp_FinCustId = "CUST",
                Comp_StirkeCustId = "ab00c",
                   comp_business_type = "Australian Company",
                comp_abn = "45777478",
                comp_acn = "A9945633",
                comp_icn = "",
                //todo add business entity model
                comp_BusinessName = "abc",
                comp_AnzsicCodes = "abc",
                //todo - add Royalty Company Model
            },
                     new CRMCompany
            {
                Comp_CompanyId = new int(),
                Comp_PrimaryPersonId = 100,
                Comp_PrimaryAddressId = 100,
                Comp_Name = "Adam JOhnson",
                Comp_Type = "Individual",
                Comp_Status = "Active",
                Comp_PrimaryAccountId = 100,
               Comp_RoyCustId = "AA12356",
                Comp_FinCustId = "CUST",
                Comp_StirkeCustId = "ab00c",
                   comp_business_type = "Individual",
                comp_abn = "",
                comp_acn = "",
                comp_icn = "",
                //todo add business entity model
                comp_BusinessName = "abc",
                comp_AnzsicCodes = "abc",
                //todo - add Royalty Company Model
            },
                        new CRMCompany
            {
                Comp_CompanyId = new int(),
                Comp_PrimaryPersonId = 100,
                Comp_PrimaryAddressId = 100,
                Comp_Name = "Alawa Aboriginal Corporation",
                Comp_Type = "ALT",
                Comp_Status = "Active",
                Comp_PrimaryAccountId = 100,
                 Comp_RoyCustId = "AA12356",
                Comp_FinCustId = "CUST",
                Comp_StirkeCustId = "ab00c",
                   comp_business_type = "Trust Holding",
                comp_abn = "",
                comp_acn = "",
                comp_icn = "78659321",
                //todo add business entity model
                comp_BusinessName = "abc",
                comp_AnzsicCodes = "abc",
                //todo - add Royalty Company Model
            }
       };

        public List<CRMCompany> GetCRMCompanies()
        {
           
            return cRMCompany;
                
            
        }
    }
}
