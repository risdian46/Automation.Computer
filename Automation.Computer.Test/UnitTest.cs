using Automation.Framework.Core.Abstraction;
using Automation.Framework.Core.DIContainer;
using Automation.Framework.Core.Params;
using Automation.Framework.Core.Report;
using Microsoft.Extensions.DependencyInjection;

namespace Automation.Computer.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            IServiceProvider serviceProvider = CoreContainerConfig.ConfigureService();
            IGlobalProperties globalProperties = serviceProvider.GetService<IGlobalProperties>();

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}