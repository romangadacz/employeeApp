using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTOs;

namespace Business
{
    public interface IEmployeeService
    {
        Task<IList<EmployeeDTO>> GetEmployees();
        Task<EmployeeDTO> GetEmployee(int id);
    }
}