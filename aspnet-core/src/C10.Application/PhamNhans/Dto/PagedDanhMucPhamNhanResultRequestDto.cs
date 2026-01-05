using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;

namespace C10.PhamNhans.Dto;

public class PagedDanhMucPhamNhanResultRequestDto : PagedResultRequestDto, IShouldNormalize
{
    public string Keyword { get; set; }
    public bool? IsActive { get; set; }
    public string Sorting { get; set; }

    public void Normalize()
    {
        if (string.IsNullOrWhiteSpace(Sorting))
        {
            Sorting = "Code";
        }

        Keyword = Keyword?.Trim();
    }
}
