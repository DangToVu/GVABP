using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.GVABP.GiangViens;

public interface IGiangVienAppService :
    ICrudAppService< //Defines CRUD methods
        GiangVienDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateGiangVienDto> //Used to create/update a book
{

}
