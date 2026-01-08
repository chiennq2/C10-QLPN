using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.MasterData.Domain.DanhMuc.DM_LoaiQDTDT;
using C10.LoaiQDTDT.Dto;

namespace C10.LoaiQDTDT
{
    public class DM_LoaiQDTDTAppService : AsyncCrudAppService<DM_LoaiQDTDT, DM_LoaiQDTDTDto, int, PageDM_LoaiQDTDTResultDto, CreateDM_LoaiQDTDTDto, DM_LoaiQDTDTDto>, IDM_LoaiQDTDTAppService
    {
        public DM_LoaiQDTDTAppService(IRepository<DM_LoaiQDTDT, int> repository) : base(repository)
        {
        }
    }
}
