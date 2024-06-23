using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.GVABP.GiangViens;

public class GiangVienAppService :
    CrudAppService<
        GiangVien, //The Book entity
        GiangVienDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateGiangVienDto>, //Used to create/update a book
    IGiangVienAppService //implement the IBookAppService
{
    public GiangVienAppService(IRepository<GiangVien, Guid> repository)
        : base(repository)
    {

    }
}
