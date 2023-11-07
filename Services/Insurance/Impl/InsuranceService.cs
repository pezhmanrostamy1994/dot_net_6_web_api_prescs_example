namespace EMR.Services;
using EMR.Dto;
using EMR.Utilities.EmrConstants;
using EMR.Services.Contracts;


public class InsuranceService : IInsuranceService
{
    public ResultDto<List<InsuranceCompanyDto>> getAllInsurances()
    {
        return new ResultDto<List<InsuranceCompanyDto>>()
        {
            Data = new List<InsuranceCompanyDto>(){
                    InsuranceConstants.Sakhad,
                    InsuranceConstants.Salamat,
                    InsuranceConstants.Tamin
            },
            Messages = new MessagesDto() { }
        };

    }
}
