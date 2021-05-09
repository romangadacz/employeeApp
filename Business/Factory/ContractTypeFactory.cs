using System;
using System.Collections.Generic;
using System.Text;
using Domain.DTOs;
using Domain.Entities;

namespace Business.Factory
{
    public class ContractTypeFactory : IContractTypeFactory
    {
        public ContractTypeDTO GetContractType(Employee employee)
        {

            if (Constants.HourlySalary == employee.ContractTypeName)
            {
                return new HourlyContractDTO(employee.HourlySalary, Constants.HourlySalary);
            }
            else
            {
                return new MonthlyContractDTO(employee.MonthlySalary, Constants.MonthlySalary);
            }

            throw new Exception("Invalid contract type");
        }
    }
}
