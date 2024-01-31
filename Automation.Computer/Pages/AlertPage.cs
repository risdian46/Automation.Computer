using Automation.Computer.WebAbstraction;
using Automation.Framework.Core.Abstraction;
using Automation.Framework.Core.Base;
using Automation.Framework.Core.DriverContext;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Automation.Computer.Pages
{
    public class AlertPage : TestBase, IAlertPage
    {
        IWebDriver _iwebDriver;
        IDriver _idrivers;
        IAtConfiguration _iatConfiguration;

        IAtBy clickJSAlertButton => GetBy(LocatorType.Xpath, "//button[@onclick='jsAlert()']");
        IAtWebElement JSAlertClickButton => _idrivers.FindElement(clickJSAlertButton);

        IAtBy clickJSConfirmButton => GetBy(LocatorType.Xpath, "//button[@onclick='jsConfirm()']");
        IAtWebElement JSConfirmClickButton => _idrivers.FindElement(clickJSConfirmButton);
        IAtBy clickJSPromptButton => GetBy(LocatorType.Xpath, "//button[@onclick='jsPrompt()']");
        IAtWebElement JSPromptClickButton => _idrivers.FindElement(clickJSPromptButton);
        IAtBy alertResultMessages => GetBy(LocatorType.Xpath, "//p[@id='result']");
        IAtWebElement AlertResult => _idrivers.FindElement(alertResultMessages);

        IAtBy clickResult => GetBy(LocatorType.Id, "result");
        IAtWebElement ConfirmResult => _idrivers.FindElement(clickResult);
        public AlertPage(IAtConfiguration iatConfiguration, IDriver iDriver, IObjectContainer objectContainer)
           : base(objectContainer)
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            _idrivers = iDriver;
            _iwebDriver = iDriver.GetWebDriver();
            _iwebDriver.Manage().Window.Maximize();
            _iatConfiguration = iatConfiguration;
        }
        public void OpenTheJSAlertWebsiteSuccessfully()
        {
            string url = _iatConfiguration.GetConfiguration("urlJSAlert");
            _idrivers.NavigateTo(url);
        }
        public void ClickButtonOfClickForJSAlert()
        {
            JSAlertClickButton.ClickWithJs();
        }
        public void ClickOKButton()
        {
            var expectedAlertText = "I am a JS Alert";

            var alert = _iwebDriver.SwitchTo().Alert();
            Assert.AreEqual(expectedAlertText, alert.Text);

            alert.Accept();
        }

        public void AlertMessageIsAppears(string expectedResult)
        {
            Assert.That(AlertResult.GetText(), Is.EqualTo(expectedResult));
        }

        public void ClickButtonOfClickForJSConfirm()
        {
            JSConfirmClickButton.ClickWithJs();
        }
        public void ClickOKJSConfirmButton()
        {
            var expectedAlertText = "I am a JS Confirm";
            var confirm = _iwebDriver.SwitchTo().Alert();
            confirm.Accept();
        }
        public void ClickCancelJSConfirmButton()
        {
            var expectedAlertText = "I am a JS Confirm";
            var confirm = _iwebDriver.SwitchTo().Alert();
            confirm.Dismiss();
        }

        public void ClickButtonOfClickForJSPrompt()
        {
            JSPromptClickButton.ClickWithJs();
        }
        public void EnterTheTextOnTheAlertPopUpMessageAndClickOK(string test)
        {
            var expectedAlertText = "I am a JS prompt";
            var prompt = _iwebDriver.SwitchTo().Alert();
            prompt.SendKeys(test);
            prompt.Accept();
        }
        public void EnterTheTextOnTheAlertPopUpMessageAndClickCancel(string test)
        {
            var expectedAlertText = "I am a JS prompt";
            var prompt = _iwebDriver.SwitchTo().Alert();
            prompt.SendKeys(test);
            prompt.Dismiss();
        }
    }
}
