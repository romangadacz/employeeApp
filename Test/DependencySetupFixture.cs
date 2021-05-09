using System;
using System.Collections.Generic;
using System.Text;
using Business;
using Business.Factory;
using DataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace Test
{
    public class DependencySetupFixture
    {
        public DependencySetupFixture()
        {
            var services = new ServiceCollection();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IContractTypeFactory, ContractTypeFactory>();
            services.AddScoped<IRepository, Repository>();

            ServiceProvider = services.BuildServiceProvider();
        }

        public ServiceProvider ServiceProvider { get; private set; }
    }
}
