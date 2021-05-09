using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTOs
{
    public class HourlyContractDTO : ContractTypeDTO
    {
        public HourlyContractDTO(double hourlySalary,string name) : base (hourlySalary,name)
        {
            
        }
        public override double AnnualSalary
        {
            get { return  120 *  amountSalary * 12; }
        }

    }
}
