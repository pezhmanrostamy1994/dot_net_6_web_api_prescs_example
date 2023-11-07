namespace EMR.Utilities.EmrConstants;
using EMR.Dto;
using EMR.Models.Enums;


public static class InsuranceConstants
{
    public const string TaminFa = "تامین";
    public const string SalamatFa = "سلامت";
    public const string SakhadFa = "ساخد";
    public static readonly InsuranceCompanyDto Tamin = new InsuranceCompanyDto(InsuranceCompanyEnum.Tamin.ToString(), TaminFa);
    public static readonly InsuranceCompanyDto Salamat = new InsuranceCompanyDto(InsuranceCompanyEnum.Salamat.ToString(), SalamatFa);
    public static readonly InsuranceCompanyDto Sakhad = new InsuranceCompanyDto(InsuranceCompanyEnum.Sakhad.ToString(), SakhadFa);
}

