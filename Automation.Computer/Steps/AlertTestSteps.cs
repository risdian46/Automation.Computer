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
    public class AlertTestSteps : IAlertTestSteps
    {
        AlertPage alertPage;
        IAtConfiguration _iatConfiguration;
        IAlertPage _ialertPage;

        public AlertTestSteps(IAtConfiguration iatConfiguration, IDriver iDriver, IObjectContainer iobjectContainer, IAlertPage ialertPage)
        {
            _iatConfiguration = iatConfiguration;
            _ialertPage = ialertPage;
        }

        [Given(@"User open the JSAlert website successfully")]
        public void GivenUserOpenTheJSAlertWebsiteSuccessfully()
        {
            _ialertPage.OpenTheJSAlertWebsiteSuccessfully();
        }

        [When(@"User click button of Click for JS Alert")]
        public void WhenUserClickButtonOfClickForJSAlert()
        {
            _ialertPage.ClickButtonOfClickForJSAlert();
        }

        [When(@"Click OK button")]
        public void WhenClickOKButton()
        {
            _ialertPage.ClickOKButton();
        }

        [Then(@"alert message ""([^""]*)"" is appears")]
        public void ThenAlertMessageIsAppears(string expectedResult)
        {
            _ialertPage.AlertMessageIsAppears(expectedResult);
        }
        [When(@"User click button of Click for JS Confirm")]
        public void WhenUserClickButtonOfClickForJSConfirm()
        {
            _ialertPage.ClickButtonOfClickForJSConfirm();
        }

        [When(@"Click OK JS Confirm button")]
        public void WhenClickOKJSConfirmButton()
        {
            _ialertPage.ClickOKJSConfirmButton();
        }
        
        [When(@"Click Cancel JS Confirm button")]
        public void WhenClickCancelJSConfirmButton()
        {
            _ialertPage.ClickCancelJSConfirmButton();
        }

        [When(@"User click button of Click for JS Prompt")]
        public void WhenUserClickButtonOfClickForJSPrompt()
        {
            _ialertPage.ClickButtonOfClickForJSPrompt();
        }

        [When(@"User enter the ""([^""]*)"" text on the alert pop up message and click OK")]
        public void WhenUserEnterTheTextOnTheAlertPopUpMessageAndClickOK(string test)
        {
            _ialertPage.EnterTheTextOnTheAlertPopUpMessageAndClickOK(test);
        }

        [When(@"User enter the ""([^""]*)"" text on the alert pop up message and click Cancel")]
        public void WhenUserEnterTheTextOnTheAlertPopUpMessageAndClickCancel(string test)
        {
            _ialertPage.EnterTheTextOnTheAlertPopUpMessageAndClickCancel(test);
        }


    }
}
