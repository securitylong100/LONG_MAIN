﻿using Com.Nidec.Mes.Framework;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Nidec.Mes.VCVP.NCVP_MasterMaintenance.Dao
{
    public class AddModelLineDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            ModelLineVo inVo = (ModelLineVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into public.m_ncvp_model_line(model_id,line_id,registration_user_cd,registration_date_time,factory_cd) ");
            sql.Append("values(:model_id,:line_id,:registration_user_cd,now(),:factory_cd)");

            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            //
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameterInteger("model_id", inVo.ModelID);
            sqlParameter.AddParameterInteger("line_id", inVo.LineID);

            sqlParameter.AddParameterString("factory_cd", inVo.FactoryCode);
            sqlParameter.AddParameterString("registration_user_cd", inVo.RegistrationUserCode);
            //execute SQL

            ModelLineVo outVo = new ModelLineVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }
    }
}
