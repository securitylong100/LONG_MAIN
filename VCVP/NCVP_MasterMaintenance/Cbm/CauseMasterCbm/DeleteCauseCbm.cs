using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.VCVP.NCVP_MasterMaintenance.Dao;

namespace Com.Nidec.Mes.VCVP.NCVP_MasterMaintenance.Cbm
{
    public class DeleteCauseCbm : CbmController
    {
        private static readonly DataAccessObject getDao = new DeleteCauseDao();
        public ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            if (vo == null)
            {
                //throw ApplicationException
                return null;
            }

            ValueObjectList<CauseVo> ll = (ValueObjectList<CauseVo>)vo;
            foreach (CauseVo v in ll.GetList())
            {
                getDao.Execute(trxContext, v);
            }
            return null;
        }
    }
}
