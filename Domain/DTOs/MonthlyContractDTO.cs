using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTOs
{
    public class MonthlyContractDTO : ContractTypeDTO
    {

        public MonthlyContractDTO(double monthlySalary, string name) : base(monthlySalary, name)
        {

        }

        public override double AnnualSalary
        {
            get
            {
                return amountSalary * 12;
            }

        }
    }
}