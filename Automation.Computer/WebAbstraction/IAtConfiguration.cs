﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Computer.WebAbstraction
{
    public interface IAtConfiguration
    {
        public string GetConfiguration(string key);
    }
}
