using Abp.Application.Services;
using C10.DanToc.Dto;


namespace C10.DanToc
{
    public interface IDM_DanTocAppService : IAsyncCrudAppService<DM_DanTocDto, int, PageDM_DanTocResultDto, CreateDM_DanTocDto, DM_DanTocDto>
    {
    }
}
