﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LUMARDMSBlazorApp.Data
{
    interface ICRMCompanyService
    {
        List<CRMCompany> GetCRMCompanies();
    }
}
