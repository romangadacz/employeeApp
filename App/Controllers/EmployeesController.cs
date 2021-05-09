using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<EmployeeDTO>>> GetEmployees()
        {
            return Ok(await _employeeService.GetEmployees());

        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<EmployeeDTO>> GetEmployee(int id)
        {
            return Ok(await _employeeService.GetEmployee(id));

        }
    }
}
