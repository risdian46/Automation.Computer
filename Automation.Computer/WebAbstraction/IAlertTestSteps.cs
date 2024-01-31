using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.Computer.WebAbstraction
{
    public interface IAlertTestSteps
    {
        void GivenUserOpenTheJSAlertWebsiteSuccessfully();
        void WhenUserClickButtonOfClickForJSAlert();
        void WhenClickOKButton();
        void ThenAlertMessageIsAppears(string expectedResult);
        void WhenClickOKJSConfirmButton();
        void WhenUserClickButtonOfClickForJSConfirm();
        void WhenClickCancelJSConfirmButton();
        void WhenUserClickButtonOfClickForJSPrompt();
        void WhenUserEnterTheTextOnTheAlertPopUpMessageAndClickOK(string test);

    }
}
