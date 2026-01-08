using Abp.Application.Services;
using Abp.Domain.Repositories;
using C10.MasterData.Domain.DanhMuc.DM_LyDoKhen;
using C10.LyDoKhen.Dto;

namespace C10.LyDoKhen
{
    public class DM_LyDoKhenAppService : AsyncCrudAppService<DM_LyDoKhen, DM_LyDoKhenDto, int, PageDM_LyDoKhenResultDto, CreateDM_LyDoKhenDto, DM_LyDoKhenDto>, IDM_LyDoKhenAppService
    {
        public DM_LyDoKhenAppService(IRepository<DM_LyDoKhen, int> repository) : base(repository)
        {
        }
    }
}
