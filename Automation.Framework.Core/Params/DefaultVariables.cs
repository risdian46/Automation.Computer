﻿using Automation.Framework.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework.Core.Params
{
    public class DefaultVariables : IDefaultVariables
    {
        public string getReport
        {
            get
            {
                return System.IO.Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory + "../../../")
                    .FullName + "\\Result\\Report"
                 + DateTime.Now.ToString("yyyyMMdd HHmmss") ;
            }
        }

        public string getLog
        {
            get
            {
                return getReport + "\\log.txt";
            }
        }

        public string getframeworkSettingjson
        {
            get
            {
                return System.IO.Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName + "\\Resources\\frameworkSettings.json";
            }
        }

        public string dataSetLocation
        {
            get
            {
                return System.IO.Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory + "../../../").FullName + "\\DataSet";
            }
        }

        public string getAppplicationConfigjson
        {
            get
            {
                return System.IO.Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName + "\\Resources\\applicationConfig.json";
            }
        }

        public string getExtentReport
        {
            get
            {
                return getReport + "\\index.html";
            }
        }
    }
}
