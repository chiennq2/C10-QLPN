using Abp.Application.Services;
using C10.PhamNhans.Dto;

namespace C10.PhamNhans;

public interface IDM_LoaiPhamNhanAppService : IAsyncCrudAppService<
    DM_LoaiPhamNhanDto,
    int,
    PagedDM_LoaiPhamNhanResultRequestDto,
    CreateDM_LoaiPhamNhanDto,
    DM_LoaiPhamNhanDto>
{
}
