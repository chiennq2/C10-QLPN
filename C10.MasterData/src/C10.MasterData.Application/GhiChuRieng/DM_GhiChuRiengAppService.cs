using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.MasterData.Domain.DanhMuc.DM_GhiChuRieng;
using C10.GhiChuRieng.Dto;


namespace C10.GhiChuRieng
{
    public class DM_GhiChuRiengAppService : AsyncCrudAppService<DM_GhiChuRieng, DM_GhiChuRiengDto, int, PageDM_GhiChuRiengResultDto, CreateDM_GhiChuRiengDto, DM_GhiChuRiengDto>, IDM_GhiChuRiengAppService
    {
        public DM_GhiChuRiengAppService(IRepository<DM_GhiChuRieng, int> repository) : base(repository) { } 
    }
}
