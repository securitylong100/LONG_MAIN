using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.VCVP.NCVP_MasterMaintenance.Dao;

namespace Com.Nidec.Mes.VCVP.NCVP_MasterMaintenance.Cbm
{
    public class AddDrawCbm : CbmController
    {
        private static readonly DataAccessObject getDao = new AddDrawDao();
        public ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            if (vo == null)
            {
                //throw ApplicationException
                return null;
            }

            return getDao.Execute(trxContext, vo);
        }
    }
}
