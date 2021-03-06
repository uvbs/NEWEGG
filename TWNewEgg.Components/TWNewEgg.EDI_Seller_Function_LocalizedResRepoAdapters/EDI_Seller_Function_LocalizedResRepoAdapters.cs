﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWNewEgg.DAL.Interface;
using TWNewEgg.EDI_Seller_Function_LocalizedResRepoAdapters.Interface;
using TWNewEgg.VendorModels.DBModels.Model;

namespace TWNewEgg.EDI_Seller_Function_LocalizedResRepoAdapters
{
    public class EDI_Seller_Function_LocalizedResRepoAdapters : IEDI_Seller_Function_LocalizedResRepoAdapters
    {
        private ITWSELLERPORTALDBRepository<EDI_Seller_Function_LocalizedRes> _eDI_Seller_Function_LocalizedRes;

        public EDI_Seller_Function_LocalizedResRepoAdapters(ITWSELLERPORTALDBRepository<EDI_Seller_Function_LocalizedRes> eDI_Seller_Function_LocalizedRes)
        {
            this._eDI_Seller_Function_LocalizedRes = eDI_Seller_Function_LocalizedRes;
        }

        public void Create(EDI_Seller_Function_LocalizedRes model)
        {
            this._eDI_Seller_Function_LocalizedRes.Create(model);
        }

        public IQueryable<EDI_Seller_Function_LocalizedRes> GetAll()
        {
            return this._eDI_Seller_Function_LocalizedRes.GetAll();
        }

        public void Update(EDI_Seller_Function_LocalizedRes model)
        {
            this._eDI_Seller_Function_LocalizedRes.Update(model);
        }
    }
}
