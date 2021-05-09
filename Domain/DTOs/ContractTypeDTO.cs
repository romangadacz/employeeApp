using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTOs
{
    public abstract class ContractTypeDTO
    {

        public string Name { get; set; }
        protected double amountSalary;

        public ContractTypeDTO(double monthlySalary, string name)
        {
            amountSalary = monthlySalary;
            Name = name;
        }

        public abstract double AnnualSalary { get; }
    }
}
