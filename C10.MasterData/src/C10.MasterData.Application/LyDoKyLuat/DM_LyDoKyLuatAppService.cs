using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.MasterData.Domain.DanhMuc.DM_LyDoKyLuat;
using C10.LyDoKyLuat.Dto;

namespace C10.LyDoKyLuat
{
    public class DM_LyDoKyLuatAppService : AsyncCrudAppService<DM_LyDoKyLuat, DM_LyDoKyLuatDto, int, PageDM_LyDoKyLuatResultDto, CreateDM_LyDoKyLuatDto, DM_LyDoKyLuatDto>, IDM_LyDoKyLuatAppService
    {
        public DM_LyDoKyLuatAppService(IRepository<DM_LyDoKyLuat, int> repository) : base(repository)
        {
        }
    }
}
