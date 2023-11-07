namespace EMR.Mappings.AutoMapperProfile;
using AutoMapper;
using EMR.Dto;
using EMR.Models.Entities;
public class PrescProfile : Profile
{
    public PrescProfile()
    {

        CreateMap<PrescriptionEntity, PrescriptionDto>();
    }
}
