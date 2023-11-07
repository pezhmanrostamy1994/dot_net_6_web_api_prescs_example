
namespace EMR.Services.Contracts;
using EMR.Dto;

public interface IPrescriptionsService
{
    public Task<ResultDto<IEnumerable<PrescriptionDto>>> getAllPrescriptionsAsync();
}

