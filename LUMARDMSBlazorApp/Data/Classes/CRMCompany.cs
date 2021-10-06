using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LUMARDMSBlazorApp.Data
{
    public class CRMCompany
    {
		public int Comp_CompanyId { get; set;}
		//todo - add person Entity
		public int Comp_PrimaryPersonId { get; set; }
		//todo - add address entity
		public int Comp_PrimaryAddressId { get; set; }
		//todo - add User
		public int Comp_PrimaryUserId { get; set; }
		public string Comp_Name { get; set; }
		//todo - add Company Type enum
		public string Comp_Type { get; set; }
		public string Comp_Status { get; set; }
		public int Comp_PrimaryAccountId { get; set; }
		public string Comp_FinCustId { get; set; }
		//todo - add Business Type enum
		public string comp_business_type { get; set; }
		public string comp_abn { get; set; }
		public string comp_acn { get; set; }
		public string comp_icn { get; set; }
		//todo add business entity model
		public string comp_BusinessName { get; set; }
		public string comp_AnzsicCodes { get; set; }	
		public string Comp_RoyCustId { get; set; }
		public string Comp_StirkeCustId { get; set; }
	}
}
