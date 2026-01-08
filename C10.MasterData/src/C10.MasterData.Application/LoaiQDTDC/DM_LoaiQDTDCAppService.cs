using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.LoaiQDTDC.Dto;
using C10.MasterData.Domain.DanhMuc.DM_LoaiQDTDC;

namespace C10.LoaiQDTDC
{
    public class DM_LoaiQDTDCAppService : AsyncCrudAppService<DM_LoaiQDTDC, DM_LoaiQDTDCDto, int, PageDM_LoaiQDTDCResultDto, CreateDM_LoaiQDTDCDto, DM_LoaiQDTDCDto>, IDM_LoaiQDTDCAppService
    {
        public DM_LoaiQDTDCAppService(IRepository<DM_LoaiQDTDC, int> repository) : base(repository)
        {
        }
    }
}
