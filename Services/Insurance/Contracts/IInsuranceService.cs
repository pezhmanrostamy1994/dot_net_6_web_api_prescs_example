
namespace EMR.Services.Contracts;
using EMR.Dto;

public interface IInsuranceService
{
    public ResultDto<List<InsuranceCompanyDto>> getAllInsurances();
}

