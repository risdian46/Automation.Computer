using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.Computer.WebAbstraction
{
    public  interface IComputerHomePage
    {
        void OpenTheComputerWebsiteSuccessfully();
        void UserCreateNewComputerByFillingTheDetails(Table table);

        void AlertMessageSuccessfullyCreatedIsAppears(string expectedMessage);

    }
}
