namespace EMR.Services;
using AutoMapper;
using EMR.Dto;
using EMR.Repo;
using EMR.Services.Contracts;

public class PrescriptionService : IPrescriptionsService
{
    private readonly IPrescriptionRepo _prescRepo;
    private readonly IMapper _mapper;

    public PrescriptionService(IPrescriptionRepo prescRepo, IMapper mapper)
    {
        _prescRepo = prescRepo;
        _mapper = mapper;

    }
    public async Task<ResultDto<IEnumerable<PrescriptionDto>>> getAllPrescriptionsAsync()
    {
        var prescs = await _prescRepo.getAllPrescriptionsAsync();
        var mapPrescs = _mapper.Map<IEnumerable<PrescriptionDto>>(prescs);

        return new ResultDto<IEnumerable<PrescriptionDto>>()
        {
            Data = mapPrescs
        };

    }
}
