using AngleSharp.Dom;
using Automation.Framework.Core.Abstraction;
using Automation.Framework.Core.DriverContext;
using Automation.Framework.Core.Params;
using Automation.Framework.Core.Report;
using Automation.Framework.Core.Reports;
using Automation.Framework.Core.Selenium.LocalWebDrivers;
using Automation.Framework.Core.Selenium.WebDrivers;
using Automation.Framework.Core.WebElements;
using BoDi;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework.Core.DIContainer
{
    public class CoreContainerConfig
    {
        public static IServiceProvider ConfigureService()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IDefaultVariables, DefaultVariables>();
            serviceCollection.AddSingleton<ILogging, Logging>();
            serviceCollection.AddSingleton<IGlobalProperties, GlobalProperties>();
            serviceCollection.AddSingleton<IExtentFeatureReport, ExtentFeatureReport>();
            serviceCollection.AddTransient<IExtentReport, ExtentReport>();
            return serviceCollection.BuildServiceProvider();
        }

        public static IObjectContainer SetContainer(IObjectContainer iobjectContainer)
        {
            iobjectContainer.RegisterTypeAs<ChromeWebDriver, IChromeWebDriver>();
            iobjectContainer.RegisterTypeAs<FirefoxWebDriver, IFirefoxWebDriver>();
            iobjectContainer.RegisterTypeAs<Driver, IDriver>();
            iobjectContainer.RegisterTypeAs<AtBy, IAtBy>();
            iobjectContainer.RegisterTypeAs<AtWebElement, IAtWebElement>();
            return iobjectContainer;
        }
    }
}
