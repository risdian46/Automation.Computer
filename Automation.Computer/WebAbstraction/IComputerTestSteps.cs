using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.Computer.WebAbstraction
{
    public interface IComputerTestSteps
    {
        void GivenUserOpenTheComputerWebsiteSuccessfully();
        void GivenUserCreateNewComputerByFillingTheDetails(Table table);

        void ThenAlertMessageSuccessfullyCreatedIsAppears(string expectedMessage);
    }
}
