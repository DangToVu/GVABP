using Acme.GVABP.GiangViens;
using AutoMapper;

namespace Acme.GVABP.Web;

public class GVABPWebAutoMapperProfile : Profile
{
    public GVABPWebAutoMapperProfile()
    {
        CreateMap<GiangVienDto, CreateUpdateGiangVienDto>();
    }
}
