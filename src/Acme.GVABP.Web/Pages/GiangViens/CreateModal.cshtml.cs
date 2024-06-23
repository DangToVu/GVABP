using System.Threading.Tasks;
using Acme.GVABP.GiangViens;
using Microsoft.AspNetCore.Mvc;

namespace Acme.GVABP.Web.Pages.GiangViens
{
    public class CreateModalModel : GVABPPageModel
    {
        [BindProperty]
        public CreateUpdateGiangVienDto GiangVien { get; set; }

        private readonly IGiangVienAppService _giangvienAppService;

        public CreateModalModel(IGiangVienAppService giangvienAppService)
        {
            _giangvienAppService = giangvienAppService;
        }

        public void OnGet()
        {
            GiangVien = new CreateUpdateGiangVienDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _giangvienAppService.CreateAsync(GiangVien);
            return NoContent();
        }
    }
}
