using System;
using System.Threading.Tasks;
using Business;
using DataAccess;
using DataAccess.Exceptions;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Test
{
    public class EmployeeTest : IClassFixture<DependencySetupFixture>
    {
        private readonly IEmployeeService _employeeService;

        private ServiceProvider _serviceProvide;
        public EmployeeTest(DependencySetupFixture fixture)
        {
            _serviceProvide = fixture.ServiceProvider;
            _employeeService = _serviceProvide.GetService<IEmployeeService>();
        }

        [Fact]
        public async Task EnterAValidEmployeeId_GetEmployee_ReturnsAValidEmployee()
        {
            const int id = 1;
            var employee = await _employeeService.GetEmployee(id);
            Assert.Equal(id, employee.Id);
            Assert.Equal("Andrea", employee.Name);
            Assert.Equal(14400000, employee.ContractType.AnnualSalary);
            Assert.Equal("HourlySalaryEmployee", employee.ContractType.Name);
            Assert.Equal("Administrator", employee.Rol.RoleName);
        }

        [Fact]
        public async Task EnterAnInValidEmployeeId_GetEmployee_ThrowsInvalidEmployeeException()
        {
            const int id = 5;
            await Assert.ThrowsAsync<InvalidEmployeeException>(async () => await _employeeService.GetEmployee(id));
        }
    }
}
