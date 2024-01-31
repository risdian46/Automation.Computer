﻿using Automation.Framework.Core.Abstraction;
using Automation.Framework.Core.DIContainer;
using Microsoft.Extensions.DependencyInjection;
using TechTalk.SpecFlow;

namespace Automation.Framework.Core.Runner
{
    [Binding]
    public class SpecflowRunner
    {
       public static IServiceProvider _iserviceProvider;
       
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            _iserviceProvider = CoreContainerConfig.ConfigureService();
            _iserviceProvider.GetRequiredService<IGlobalProperties>();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext fc)
        {
            IExtentReport iextentReport = _iserviceProvider.GetRequiredService<IExtentReport>();
            iextentReport.CreateFeature(fc.FeatureInfo.Title);
            fc["iextentreport"] = iextentReport;
        }

    }
}
