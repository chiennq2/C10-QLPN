using Abp.Application.Services;
using C10.BenhTat.Dto;

namespace C10.BenhTat
{
    public interface IDM_BenhTatAppService : IAsyncCrudAppService<DM_BenhTatDto, int, PagedDM_BenhTatResultDto, CreateDM_BenhTatDto, DM_BenhTatDto>
    {
    }
}
