using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Domain.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ContractTypeDTO ContractType { get; set; }
        public RolDTO Rol { get; set; }

    }
}
