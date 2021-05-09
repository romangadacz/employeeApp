using Domain.DTOs;
using Domain.Entities;

namespace Business.Factory
{
    public interface IContractTypeFactory
    {
        ContractTypeDTO GetContractType(Employee employee);
    }
}