using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.DTOs;
using Domain.Entities;

namespace DataAccess
{
    public interface IRepository
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();
        Task<Employee> GetEmployeeAsync(int id);
    }
}