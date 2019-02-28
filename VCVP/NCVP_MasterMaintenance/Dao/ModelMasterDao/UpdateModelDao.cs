using Com.Nidec.Mes.Framework;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Nidec.Mes.VCVP.NCVP_MasterMaintenance.Dao
{
    public class UpdateModelDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            ModelVo inVo = (ModelVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append("update public.m_ncvp_model set model_cd=:model_cd,model_name=:model_name");
            sql.Append(" where model_id =:model_id");
            
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameterString("model_cd", inVo.ModelCode);
            sqlParameter.AddParameterString("model_name", inVo.ModelName);
            sqlParameter.AddParameterInteger("model_id", inVo.ModelId);
           

            sqlParameter.AddParameterString("factory_cd", inVo.FactoryCode);
            sqlParameter.AddParameterString("registration_user_cd", inVo.RegistrationUserCode);
            //execute SQL

            ModelVo outVo = new ModelVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }
    }
}
