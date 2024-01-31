using Automation.Computer.WebAbstraction;
using Automation.Framework.Core.Abstraction;
using Automation.Framework.Core.Base;
using Automation.Framework.Core.Utils;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace Automation.Computer.Pages
{
    public class ComputerHomePage : TestBase, IComputerHomePage
    {
        IWebDriver _iwebDriver;
        IDriver _idrivers;
        IAtConfiguration _iatConfiguration;

        IAtBy addNewComputerButton => GetBy(LocatorType.Id, "add");
        IAtWebElement AddNewComputer => _idrivers.FindElement(addNewComputerButton);

        IAtBy computerNameField => GetBy(LocatorType.Id, "name");
        IAtWebElement ComputerNameTextField => _idrivers.FindElement(computerNameField);

        IAtBy introducedField => GetBy(LocatorType.Id, "introduced");
        IAtWebElement IntroducedTextField => _idrivers.FindElement(introducedField);

        IAtBy discontinuedField => GetBy(LocatorType.Id, "discontinued");
        IAtWebElement DiscontinuedTextField => _idrivers.FindElement(discontinuedField);

        IAtBy companyOption => GetBy(LocatorType.Id, "company");
        IAtWebElement CompanyDropDownOption => _idrivers.FindElement(companyOption);

        IAtBy createComputerButton => GetBy(LocatorType.Xpath, "//input[@value='Create this computer']");
        IAtWebElement CreateComputerBtn => _idrivers.FindElement(createComputerButton);

        IAtBy alertSuccessfullyMessage => GetBy(LocatorType.Xpath, "//div[@class='alert-message warning']");
        IAtWebElement alertMessage => _idrivers.FindElement(alertSuccessfullyMessage);

        public ComputerHomePage(IAtConfiguration iatConfiguration, IDriver iDriver, IObjectContainer objectContainer)
            : base(objectContainer)
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            _idrivers = iDriver;
            _iwebDriver = iDriver.GetWebDriver();
            _iwebDriver.Manage().Window.Maximize();
            _iatConfiguration = iatConfiguration;
        }
        public void OpenTheComputerWebsiteSuccessfully()
        {
            string url = _iatConfiguration.GetConfiguration("urlComputer");
            _idrivers.NavigateTo(url);
        }

        public void UserCreateNewComputerByFillingTheDetails(Table table) 
        {
            AddNewComputer.Click();
            var dictionary = TableExtensions.ToDictionary(table);
            ComputerNameTextField.SendKeys(dictionary["ComputerName"]);
            IntroducedTextField.SendKeys(dictionary["Introduced"]);
            DiscontinuedTextField.SendKeys(dictionary["Discontinued"]);
            CompanyDropDownOption.SelectByText(dictionary["Company"]);
            CreateComputerBtn.ClickWithJs();
        }
        public void AlertMessageSuccessfullyCreatedIsAppears(string expectedMessage)
        {
            Assert.That(alertMessage.GetText(), Is.EqualTo(expectedMessage));
        }
    }
}
