﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;
namespace Com.Nidec.Mes.VCVP.NCVP_MasterMaintenance.Vo
{
    public class DrawProcessVo : ValueObject
    {/// <summary>
     /// / get and set ModelId
     /// </summary>
        public int DrawProcessID { get; set; }
        public int DrawID { get; set; }
        public int ProcessID { get; set; }
        /// <summary>


        /// <summary>
        /// / get and set RegistrationUserCode
        /// </summary>
        public string RegistrationUserCode { get; set; }
        /// <summary>
        /// / get and set RegistrationDateTime
        /// </summary>
        public DateTime RegistrationDateTime { get; set; }
        /// <summary>
        /// / get and set FactoryCode
        /// </summary>
        public string FactoryCode { get; set; }

        /// <summary>
        /// get and set AffectedCount
        /// </summary>
        public int AffectedCount = 0;
    }
}
