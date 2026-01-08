using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;

namespace C10.PhamNhans.Dto;

public class PagedDM_LoaiPhamNhanResultRequestDto : PagedResultRequestDto, IShouldNormalize
{
    public string Keyword { get; set; }
    public int? LPN_Trang_Thai { get; set; }
    public string Sorting { get; set; }

    public void Normalize()
    {
        if (string.IsNullOrWhiteSpace(Sorting))
        {
            Sorting = "LPN_Ma";
        }

        Keyword = Keyword?.Trim();
    }
}
