﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.VCVP.NCVP_MasterMaintenance.Dao;

namespace Com.Nidec.Mes.VCVP.NCVP_MasterMaintenance.Cbm
{
    public class DeleteResponseMachineCbm : CbmController
    {
        private static readonly DataAccessObject getDao = new DeleteResponseMachineDao();
        public ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            if (vo == null)
            {
                //throw ApplicationException
                return null;
            }

            ValueObjectList<ResponseMachineVo> ll = (ValueObjectList<ResponseMachineVo>)vo;
            foreach (ResponseMachineVo v in ll.GetList())
            {
                getDao.Execute(trxContext, v);
            }
            return null;
        }
    }
}
