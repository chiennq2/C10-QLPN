using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.MasterData.Domain.DanhMuc.DM_HinhPhatBoSung;
using C10.HinhPhatBoSung.Dto;

namespace C10.HinhPhatBoSung
{
    public class DM_HinhPhatBoSungAppService : AsyncCrudAppService<DM_HinhPhatBoSung, DM_HinhPhatBoSungDto, int, PageDM_HinhPhatBoSungResultDto, CreateDM_HinhPhatBoSungDto, DM_HinhPhatBoSungDto>, IDM_HinhPhatBoSungAppService
    {
        public DM_HinhPhatBoSungAppService(IRepository<DM_HinhPhatBoSung, int> repository) : base(repository)
        {
        }
    }
}
