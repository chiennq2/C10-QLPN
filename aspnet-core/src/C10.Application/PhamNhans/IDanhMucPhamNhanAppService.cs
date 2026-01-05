using Abp.Application.Services;
using C10.PhamNhans.Dto;

namespace C10.PhamNhans;

public interface IDanhMucPhamNhanAppService : IAsyncCrudAppService<
    DanhMucPhamNhanDto,
    int,
    PagedDanhMucPhamNhanResultRequestDto,
    CreateDanhMucPhamNhanDto,
    DanhMucPhamNhanDto>
{
}
