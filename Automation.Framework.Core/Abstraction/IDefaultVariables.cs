﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework.Core.Abstraction
{
    public interface IDefaultVariables
    {
        public string getLog { get; }
        public string getframeworkSettingjson { get; }
       public string dataSetLocation { get; }
       public string getAppplicationConfigjson { get; }
        public string getExtentReport { get; }
    }
}
