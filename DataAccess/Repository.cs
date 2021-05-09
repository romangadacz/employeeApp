using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DataAccess.Exceptions;
using Domain.DTOs;
using Domain.Entities;
using Newtonsoft.Json;

namespace DataAccess
{
    public class Repository : IRepository
    {
        const string apiURL = "http://masglobaltestapi.azurewebsites.net/api/Employees";

        public async Task<Employee> GetEmployeeAsync(int id)
        {
            var employees = await GetEmployeesAsync();

            var employee =  employees.SingleOrDefault(x => x.Id == id);
            if (employee == null)
            {
                throw new InvalidEmployeeException();
            }
            return employee;

        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(apiURL))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<Employee>>(apiResponse);
                }
            }
        }
    }
}
