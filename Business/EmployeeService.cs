using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Factory;
using DataAccess;
using Domain.DTOs;
namespace Business
{
    public class EmployeeService : IEmployeeService
    {

        private readonly IContractTypeFactory _contractTypeFactory;
        private readonly IRepository _repository;
        public EmployeeService(IContractTypeFactory contractTypeFactory, IRepository repository)
        {
            _contractTypeFactory = contractTypeFactory;
            _repository = repository;
        }
        public async Task<IList<EmployeeDTO>> GetEmployees()
        {
            var employees = await _repository.GetEmployees();
            var employeesDTO = new List<EmployeeDTO>();

            foreach (var employee in employees)
            {
                EmployeeDTO employeeDTO = ConvertEmployeeToDTO(employee);

                employeesDTO.Add(employeeDTO);
            }
            return employeesDTO;
        }

        public async Task<EmployeeDTO> GetEmployee(int id)
        {
            var employee = await _repository.GetEmployee(id);
            return ConvertEmployeeToDTO(employee);
        }

        private EmployeeDTO ConvertEmployeeToDTO(Domain.Entities.Employee employee)
        {
            return new EmployeeDTO
            {
                ContractType = _contractTypeFactory.GetContractType(employee),
                Id = employee.Id,
                Name = employee.Name,
                Rol = new RolDTO()
                {
                    RoleId = employee.RoleId,
                    RoleName = employee.RoleName,
                    RoleDescription = employee.RoleDescription,
                }
            };
        }

    }
}
