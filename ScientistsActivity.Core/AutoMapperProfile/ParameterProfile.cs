using AutoMapper;
using ScientistsActivity.Core.BusinessLogic;
using ScientistsActivity.Core.Dto;
using ScientistsActivity.Core.Models;

namespace ScientistsActivity.Core.AutoMapperProfile;

public class ParameterProfile : Profile
{
    public ParameterProfile()
    {
        CreateMap<ParametersDto, Parameters>();
    }
}
