using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.CapToaXu.Dto;
using C10.MasterData.Domain.DanhMuc.DM_CapToaXu;


namespace C10.CapToaXu
{
    public class DM_CapToaXuAppService : AsyncCrudAppService<DM_CapToaXu, DM_CapToaXuDto, int,  PageDM_CapToaXuResultDto, CreateDM_CapToaXuDto, DM_CapToaXuDto>, IDM_CapToaXuAppService
    {
        public DM_CapToaXuAppService(IRepository<DM_CapToaXu, int> repository) : base(repository)
        {
        }
    }
}
