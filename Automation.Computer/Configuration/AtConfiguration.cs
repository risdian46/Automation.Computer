using Automation.Computer.WebAbstraction;
using Automation.Framework.Core.Abstraction;
using Automation.Framework.Core.Runner;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Automation.Computer.Configuration
{
    public class AtConfiguration : IAtConfiguration
    {
        IConfiguration _iconfiguration;
        public AtConfiguration()
        {
            IDefaultVariables idefaultVariables = SpecflowRunner._iserviceProvider.GetRequiredService<IDefaultVariables>();
            _iconfiguration = new ConfigurationBuilder().AddJsonFile(idefaultVariables.getAppplicationConfigjson).Build();
        }

        public string GetConfiguration(string key)
        {
            return _iconfiguration[key];
        }
    }
}
