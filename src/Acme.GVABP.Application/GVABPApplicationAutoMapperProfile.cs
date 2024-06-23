using Acme.GVABP.GiangViens;
using AutoMapper;

namespace Acme.GVABP;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        CreateMap<GiangVien, GiangVienDto>();
        CreateMap<CreateUpdateGiangVienDto, GiangVien>();
    }
}
