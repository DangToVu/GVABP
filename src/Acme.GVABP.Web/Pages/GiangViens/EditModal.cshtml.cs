using System;
using System.Threading.Tasks;
using Acme.GVABP.GiangViens;
using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace Acme.GVABP.Web.Pages.GiangViens;

public class EditModalModel : GVABPPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateUpdateGiangVienDto GiangVien { get; set; }

    private readonly IGiangVienAppService _giangvienAppService;

    public EditModalModel(IGiangVienAppService giangvienAppService)
    {
        _giangvienAppService = giangvienAppService;
    }

    public async Task OnGetAsync()
    {
        var giangvienDto = await _giangvienAppService.GetAsync(Id);
        GiangVien = ObjectMapper.Map<GiangVienDto, CreateUpdateGiangVienDto>(giangvienDto);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _giangvienAppService.UpdateAsync(Id, GiangVien);
        return NoContent();
    }
}
