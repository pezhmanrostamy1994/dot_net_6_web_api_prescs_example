namespace EMR.Dto;
using EMR.Models.Enums;
using EMR.Utilities.EmrConstants;




public class InsuranceCompanyDto
{
    public string Name { get; set; }
    public string Value { get; set; }


    public InsuranceCompanyDto(string name, string value)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Value = value ?? throw new ArgumentNullException(nameof(value));
    }

    // این متد مقدار DTO متناسب با enum را برمی‌گرداند.
    public InsuranceCompanyDto GetInsuranceCompanyDto(InsuranceCompanyEnum InsuranceCompany)
    {
        return InsuranceCompany switch
        {
            InsuranceCompanyEnum.Tamin => InsuranceConstants.Tamin,
            InsuranceCompanyEnum.Salamat => InsuranceConstants.Salamat,
            InsuranceCompanyEnum.Sakhad => InsuranceConstants.Sakhad,
            _ => throw new ArgumentOutOfRangeException(nameof(InsuranceCompany), $"The insurance company {InsuranceCompany} is not supported.")
        };
    }

}

