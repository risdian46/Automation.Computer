using Automation.Computer.Pages;
using Automation.Computer.WebAbstraction;
using Automation.Framework.Core.Abstraction;
using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.Computer.Steps
{
    [Binding]
    public class ComputerTestSteps : IComputerTestSteps
    {
        ComputerHomePage computerHomePage;
        IAtConfiguration _iatConfiguration;
        IComputerHomePage _icomputerHomePage;

        public ComputerTestSteps(IAtConfiguration iatConfiguration, IDriver iDriver, IObjectContainer iobjectContainer, IComputerHomePage icomputerHomePage)
        {
            _iatConfiguration = iatConfiguration;
            _icomputerHomePage= icomputerHomePage;
        }

        [Given(@"User open the Computer website successfully")]
        public void GivenUserOpenTheComputerWebsiteSuccessfully()
        {
            _icomputerHomePage.OpenTheComputerWebsiteSuccessfully();
        }

        [Given(@"User create new Computer by filling the details")]
        public void GivenUserCreateNewComputerByFillingTheDetails(Table table)
        {
            _icomputerHomePage.UserCreateNewComputerByFillingTheDetails(table);
        }

        [Then(@"alert message ""([^""]*)"" successfully created is appears")]
        public void ThenAlertMessageSuccessfullyCreatedIsAppears(string expectedMessage)
        {
            _icomputerHomePage.AlertMessageSuccessfullyCreatedIsAppears(expectedMessage);
        }



    }
}
