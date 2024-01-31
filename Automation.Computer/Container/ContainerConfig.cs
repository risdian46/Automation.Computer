using Automation.Computer.Configuration;
using Automation.Computer.Pages;
using Automation.Computer.Steps;
using Automation.Computer.WebAbstraction;
using Automation.Framework.Core.Abstraction;
using Automation.Framework.Core.DIContainer;
using BoDi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.Computer.Container
{
    [Binding]
    public class ContainerConfig
    {

        [BeforeScenario(Order =1)]
        public void BeforeScenario(IObjectContainer iobjectContainer)
        {

            iobjectContainer.RegisterTypeAs<AtConfiguration, IAtConfiguration>();
            iobjectContainer.RegisterTypeAs<ComputerHomePage, IComputerHomePage>();
            iobjectContainer.RegisterTypeAs<ComputerTestSteps,IComputerTestSteps>();
            iobjectContainer.RegisterTypeAs<AlertPage, IAlertPage>();
            iobjectContainer.RegisterTypeAs<AlertTestSteps, IAlertTestSteps>();
            iobjectContainer = CoreContainerConfig.SetContainer(iobjectContainer);
        }
    }
}
