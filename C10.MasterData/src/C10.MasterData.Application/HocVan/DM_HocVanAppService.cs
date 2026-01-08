using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.MasterData.Domain.DanhMuc.DM_HocVan;
using C10.HocVan.Dto;

namespace C10.HocVan
{
    public class DM_HocVanAppService : AsyncCrudAppService<DM_HocVan, DM_HocVanDto, int, PageDM_HocVanResultDto, CreateDM_HocVanDto, DM_HocVanDto>, IDM_HocVanAppService
    {
        public DM_HocVanAppService(IRepository<DM_HocVan, int> repository) : base(repository)
        {
        }
    }
}
