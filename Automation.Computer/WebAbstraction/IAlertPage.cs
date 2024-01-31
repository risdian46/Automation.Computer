using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.Computer.WebAbstraction
{
    public interface IAlertPage
    {
        void OpenTheJSAlertWebsiteSuccessfully();
        void ClickButtonOfClickForJSAlert();

        void ClickOKButton();

        void AlertMessageIsAppears(string expectedResult);

        void ClickButtonOfClickForJSConfirm();
        void ClickOKJSConfirmButton();
        void ClickCancelJSConfirmButton();

        void ClickButtonOfClickForJSPrompt();
        void EnterTheTextOnTheAlertPopUpMessageAndClickOK(string test);

        void EnterTheTextOnTheAlertPopUpMessageAndClickCancel(string test);
    }
}
