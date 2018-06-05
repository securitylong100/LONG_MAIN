using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Nidec.Mes.VCVP.NCVP_MasterMaintenance.Dao
{
    public class DeleteCauseDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            CauseVo inVo = (CauseVo)vo;
            StringBuilder sql = new StringBuilder();
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, string.Empty);
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append("delete from  public.m_ncvp_cause Where 1=1 ");

            if (!String.IsNullOrEmpty(inVo.FactoryCode))
            {
                sql.Append(" and factory_cd = :factory_cd ");
                sqlParameter.AddParameterString("factory_cd", inVo.FactoryCode);
            }
            if (inVo.MachineID > 0)
            {
                sql.Append(" and machine_id = :machine_id ");
                sqlParameter.AddParameterInteger("machine_id", inVo.MachineID);
            }
            if (inVo.DefectiveID > 0)
            {
                sql.Append(" and defective_reason_id = :defective_reason_id ");
                sqlParameter.AddParameterInteger("defective_reason_id", inVo.DefectiveID);
            }
            if (inVo.CauseID > 0)
            {
                sql.Append(" and cause_id = :cause_id ");
                sqlParameter.AddParameterInteger("cause_id", inVo.CauseID);
            }




            //create command
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());


            //execute SQL

            MachineVo outVo = new MachineVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }
    }
}
